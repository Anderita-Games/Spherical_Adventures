using UnityEngine;
using System.Collections;

[System.Serializable]
public partial class Tilt : MonoBehaviour
{
    public float speed;
    [Tooltip("Use gyro gravity when available; fall back to accelerometer/input axis.")]
    public bool useGyroIfAvailable = true;
    private bool gyroEnabled;
    private float lastReported;
    private float logTimer;
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
                Debug.LogWarning("[Tilt] No tilt input detected. accel.x=" + Input.acceleration.x.ToString("F3") +
                                 ", gyroEnabled=" + gyroEnabled +
                                 ", gyroGravity.x=" + (Input.gyro.enabled ? Input.gyro.gravity.x.ToString("F3") : "n/a") +
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
            Input.gyro.enabled = true;
            gyroEnabled = true;
        }
    }

    private float ReadTilt()
    {
        // Prefer gyro gravity (more stable) when enabled
        float gyroX = (gyroEnabled && Input.gyro.enabled) ? Input.gyro.gravity.x : 0f;
        float accelX = SystemInfo.supportsAccelerometer ? Input.acceleration.x : 0f;

        float horizontal = gyroEnabled ? gyroX : accelX;

        // Fallback to accel if gyro reports zero but accel has data
        if (gyroEnabled && Mathf.Approximately(horizontal, 0f))
        {
            horizontal = accelX;
        }

        // Editor fallback: allow keyboard A/D or left/right arrows to simulate tilt
        if (Application.isEditor && Mathf.Approximately(horizontal, 0f))
        {
            horizontal = Input.GetAxis("Horizontal");
        }

        lastReported = horizontal;
        return horizontal;
    }

}