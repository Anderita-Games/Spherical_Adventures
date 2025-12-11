using UnityEngine;
using System.Collections;

[System.Serializable]
public partial class ControllBall : MonoBehaviour
{
    public int rotationSpeed;
    public float moveSpeed;
    public Transform target;
    public virtual void Update()
    {
        //Handle ball rotation
        float rotation = Input.GetAxis("Horizontal") * this.rotationSpeed;
        rotation = rotation * Time.deltaTime;
        this.GetComponent<Rigidbody>().AddRelativeTorque(Vector3.back * rotation);
    }

    public ControllBall()
    {
        this.rotationSpeed = 100;
        this.moveSpeed = 1f;
    }

}