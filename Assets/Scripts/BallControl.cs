using UnityEngine;
using System.Collections;
using UnityEngine.InputSystem;

[System.Serializable]
public partial class BallControl : MonoBehaviour
{
    public int jumpHeight;
    public AudioClip Jump;
    public Transform target;
    private bool isFalling;
    private InputAction jumpAction;
    private InputAction altJumpAction;
    public virtual void Update()
    {
        bool jumpPressed = jumpAction.WasPressedThisFrame() || altJumpAction.WasPressedThisFrame();
        if (jumpPressed && (this.isFalling == false))
        {

            {
                int _1 = this.jumpHeight;
                Vector3 _2 = this.GetComponent<Rigidbody>().linearVelocity;
                _2.y = _1;
                this.GetComponent<Rigidbody>().linearVelocity = _2;
            }
            this.GetComponent<AudioSource>().PlayOneShot(this.Jump);
            this.isFalling = true;
        }
        else
        {
            if (jumpPressed && (this.isFalling == false))
            {

                {
                    int _3 = this.jumpHeight;
                    Vector3 _4 = this.GetComponent<Rigidbody>().linearVelocity;
                    _4.y = _3;
                    this.GetComponent<Rigidbody>().linearVelocity = _4;
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

    private void Awake()
    {
        // Separate actions so users can bind differently if desired
        jumpAction = new InputAction("JumpPrimary", InputActionType.Button);
        jumpAction.AddBinding("<Keyboard>/space");
        jumpAction.AddBinding("<Keyboard>/w");
        jumpAction.AddBinding("<Gamepad>/buttonSouth");

        altJumpAction = new InputAction("JumpAlternate", InputActionType.Button);
        altJumpAction.AddBinding("<Keyboard>/upArrow");
        altJumpAction.AddBinding("<Gamepad>/leftShoulder");

    }

    private void OnEnable()
    {
        jumpAction?.Enable();
        altJumpAction?.Enable();
    }

    private void OnDisable()
    {
        jumpAction?.Disable();
        altJumpAction?.Disable();
    }

    private void OnDestroy()
    {
        jumpAction?.Dispose();
        altJumpAction?.Dispose();
    }

    public BallControl()
    {
        this.jumpHeight = 8;
    }

}