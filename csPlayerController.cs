using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class csPlayerController : MonoBehaviour
{
    public float walkSpeed = 3.0f;      // walk speed
    public float gravity = 20.0f;       // gravity
    public float jumpSpeed = 8.0f;      // jump speed
    private Vector3 velocity;           // current speed
    CharacterController controller = null;
    void Start()
    {
        // rapid walk
        GetComponent<Animation>()["walk"].speed = 2.0f;
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
      if (controller.isGrounded)
        {
            // decide speed by key input
            velocity = new Vector3(CrossPlatformInputManager.GetAxis("Horizontal"), 0, CrossPlatformInputManager.GetAxis("Vertical"));
            velocity *= walkSpeed;
            
            // Jump
            if(CrossPlatformInputManager.GetButtonDown("Jump"))
            {
                velocity.y = jumpSpeed;
                GetComponent<Animation>().Play("idlebattle");
            }
            else
            {
                if(velocity.magnitude > 0.5)
                {
                    // turn walk animation
                    GetComponent<Animation>().CrossFade("walk", 0.1f);
                    transform.LookAt(transform.position + velocity);
                }
                else
                {
                    GetComponent<Animation>().CrossFade("idle", 0.1f);
                }
            }
        }
        // add speed (gravity)
        velocity.y -= gravity * Time.deltaTime;

        // move character controller
        controller.Move(velocity * Time.deltaTime);
    }
}
