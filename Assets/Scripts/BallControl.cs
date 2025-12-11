using UnityEngine;
using System.Collections;

[System.Serializable]
public partial class BallControl : MonoBehaviour
{
    public int jumpHeight;
    public AudioClip Jump;
    public Transform target;
    private bool isFalling;
    public virtual void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && (this.isFalling == false))
        {

            {
                int _1 = this.jumpHeight;
                Vector3 _2 = this.GetComponent<Rigidbody>().velocity;
                _2.y = _1;
                this.GetComponent<Rigidbody>().velocity = _2;
            }
            this.GetComponent<AudioSource>().PlayOneShot(this.Jump);
            this.isFalling = true;
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Space) && (this.isFalling == false))
            {

                {
                    int _3 = this.jumpHeight;
                    Vector3 _4 = this.GetComponent<Rigidbody>().velocity;
                    _4.y = _3;
                    this.GetComponent<Rigidbody>().velocity = _4;
                }
                this.GetComponent<AudioSource>().PlayOneShot(this.Jump);
                this.isFalling = true;
            }
        }
    }

    public virtual void OnCollisionStay()
    {
        this.isFalling = false;
    }

    public BallControl()
    {
        this.jumpHeight = 8;
    }

}