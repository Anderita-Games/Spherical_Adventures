using UnityEngine;
using System.Collections;

[System.Serializable]
public partial class ControllBall : MonoBehaviour
{
    private Rigidbody rb;
    public int rotationSpeed;
    public float maxHorizontalSpeed;
    public Transform target;
    public virtual void Awake()
    {
        this.rb = this.GetComponent<Rigidbody>();
    }
    public virtual void FixedUpdate()
    {
        // Handle ball rotation with physics timestep
        float rotation = Input.GetAxisRaw("Horizontal") * this.rotationSpeed;
        rotation = rotation * Time.fixedDeltaTime;
        this.rb.AddRelativeTorque(Vector3.back * rotation);

        // Match max horizontal speed to Tilt by directly setting velocity.x
        float horizontal = Input.GetAxis("Horizontal");
        Vector3 velocity = this.rb.velocity;
        velocity.x = horizontal * this.maxHorizontalSpeed;
        this.rb.velocity = velocity;
    }

    public ControllBall()
    {
        this.rotationSpeed = 100;
        this.maxHorizontalSpeed = 10f;
    }

}