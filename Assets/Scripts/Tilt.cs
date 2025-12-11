using UnityEngine;
using System.Collections;
using UnityEngine.InputSystem;

[System.Serializable]
public partial class Tilt : MonoBehaviour
{
    public float speed;
    [Tooltip("Use gyro gravity when available; fall back to accelerometer/input axis.")]
    public bool useGyroIfAvailable = true;
    private bool gyroEnabled;
    private float lastReported;
    private float logTimer;
    private InputAction horizontalAction;
    // Move object using accelerometer
    public virtual void Update()
    {
        float horizontal = ReadTilt();
        Vector3 velocity = this.GetComponent<Rigidbody>().linearVelocity;
        velocity.x = horizontal * 10f; // match previous scaling
        this.GetComponent<Rigidbody>().linearVelocity = velocity;

        // Occasionally log when we see no movement for easier device debugging
        logTimer += Time.deltaTime;
        if (logTimer > 2f)
        {
            logTimer = 0f;
            if (Mathf.Approximately(Mathf.Abs(horizontal), 0f))
            {
                var gravity = GravitySensor.current;
                var accel = Accelerometer.current;
                Debug.LogWarning("[Tilt] No tilt input detected. accel.x=" +
                                 (accel != null ? accel.acceleration.ReadValue().x.ToString("F3") : "n/a") +
                                 ", gyroEnabled=" + gyroEnabled +
                                 ", gravity.x=" + (gravity != null ? gravity.gravity.ReadValue().x.ToString("F3") : "n/a") +
                                 ", accelPresent=" + (accel != null) +
                                 ", gravityPresent=" + (gravity != null) +
                                 ", supportsAccel=" + SystemInfo.supportsAccelerometer +
                                 ", supportsGyro=" + SystemInfo.supportsGyroscope);
            }
        }
    }

    public Tilt()
    {
        this.speed = 10f;
        this.useGyroIfAvailable = true;
    }

    private void Awake()
    {
        if (this.useGyroIfAvailable && SystemInfo.supportsGyroscope)
        {
            var gravity = GravitySensor.current;
            if (gravity != null)
            {
                InputSystem.EnableDevice(gravity);
                gyroEnabled = true;
            }
        }

        // Ensure accelerometer is enabled so we have a fallback
        if (Accelerometer.current != null)
        {
            InputSystem.EnableDevice(Accelerometer.current);
        }

        // Keyboard/gamepad fallback for editor/devices without sensors
        horizontalAction = new InputAction("Horizontal", InputActionType.Value);
        var composite = horizontalAction.AddCompositeBinding("1DAxis");
        composite.With("negative", "<Keyboard>/a");
        composite.With("negative", "<Keyboard>/leftArrow");
        composite.With("positive", "<Keyboard>/d");
        composite.With("positive", "<Keyboard>/rightArrow");
        horizontalAction.AddBinding("<Gamepad>/leftStick/x");
    }

    private void OnEnable()
    {
        horizontalAction?.Enable();
    }

    private void OnDisable()
    {
        horizontalAction?.Disable();
    }

    private void OnDestroy()
    {
        horizontalAction?.Dispose();
    }

    private float ReadTilt()
    {
        // Prefer gravity sensor (more stable) when enabled
        var gravity = GravitySensor.current;
        var accel = Accelerometer.current;

        float gyroX = gyroEnabled && gravity != null
            ? gravity.gravity.ReadValue().x
            : 0f;
        float accelX = accel != null
            ? accel.acceleration.ReadValue().x
            : 0f;

        float horizontal = gyroEnabled ? gyroX : accelX;

        // Fallback to accel if gyro reports zero but accel has data
        if (gyroEnabled && Mathf.Approximately(horizontal, 0f))
        {
            horizontal = accelX;
        }

        // Editor fallback: allow keyboard A/D or left/right arrows to simulate tilt
        if (Application.isEditor && Mathf.Approximately(horizontal, 0f))
        {
            horizontal = horizontalAction.ReadValue<float>();
        }

        lastReported = horizontal;
        return horizontal;
    }

}