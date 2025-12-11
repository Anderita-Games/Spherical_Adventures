using UnityEngine;
using System.Collections;
using UnityEngine.InputSystem;

[System.Serializable]
public partial class ControllBall : MonoBehaviour
{
    private Rigidbody rb;
    public int rotationSpeed;
    public float maxHorizontalSpeed;
    public Transform target;
    private InputAction horizontalAction;
    public virtual void Awake()
    {
        this.rb = this.GetComponent<Rigidbody>();

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
    public virtual void FixedUpdate()
    {
        // Handle ball rotation with physics timestep
        float rotation = horizontalAction.ReadValue<float>() * this.rotationSpeed;
        rotation = rotation * Time.fixedDeltaTime;
        this.rb.AddRelativeTorque(Vector3.back * rotation);

        // Match max horizontal speed to Tilt by directly setting velocity.x
        float horizontal = rotationSpeed == 0 ? 0f : horizontalAction.ReadValue<float>();
        Vector3 velocity = this.rb.linearVelocity;
        velocity.x = horizontal * this.maxHorizontalSpeed;
        this.rb.linearVelocity = velocity;
    }

    public ControllBall()
    {
        this.rotationSpeed = 100;
        this.maxHorizontalSpeed = 10f;
    }

}