using UnityEngine;
using System.Collections;

[System.Serializable]
public partial class Tilt : MonoBehaviour
{
    public float speed;
    // Move object using accelerometer
    public virtual void Update()
    {
        Vector3 dir = Vector3.zero;
        // we assume that device is held parallel to the ground
        // and Home button is in the right hand
        // remap device acceleration axis to game coordinates:
        //  1) XY plane of the device is mapped onto XZ plane
        //  2) rotated 90 degrees around Y axis
        dir.x = Input.acceleration.x;
        // clamp acceleration vector to unit sphere
        if (dir.sqrMagnitude > 1)
        {
            dir.Normalize();
        }
        // Make it move 10 meters per second instead of 10 meters per frame...
        dir = dir * Time.deltaTime;

        {
            float _13 = // Move object
            Input.acceleration.x * 10;
            Vector3 _14 = this.GetComponent<Rigidbody>().velocity;
            _14.x = _13;
            this.GetComponent<Rigidbody>().velocity = _14;
        }
    }

    public Tilt()
    {
        this.speed = 10f;
    }

}