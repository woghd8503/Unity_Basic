using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Character controller에 의해 keyboard 입력을 받아 jump, 좌우 이동 
public class csAnimationLegacy1 : MonoBehaviour
{
    public float walkSpeed = 2.0f;  // walk speed
    public float gravity = 20.0f;   // gravity
    public float jumpSpeed = 8.0f;  // jump speed
    private Vector3 velocity;       // current speed

    CharacterController controller;
    void Start()
    {
        controller = GetComponent<CharacterController>();
        // rapid walk
        GetComponent<Animation>()["walk"].speed = 1.5f;
    }

    void Update()
    {
        if(controller.isGrounded)
        {
            // decide speed by key input
            velocity = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            velocity *= walkSpeed;
            
            // jump
            if(Input.GetButtonDown("Jump"))
            {
                velocity.y = jumpSpeed;
                StartCoroutine("doJump");
            }
            else if(velocity.magnitude > 0.5)
            {
                // turn walk animaiton
                GetComponent<Animation>().CrossFade("walk", 0.1f);
                transform.LookAt(transform.position + velocity);
            }
            else
            {
                GetComponent<Animation>().CrossFade("idle", 0.1f);
            }
        }

        // add speed (gravity)
        velocity.y -= gravity * Time.deltaTime;

        // move charcter controller
        controller.Move(velocity * Time.deltaTime);
    }

    IEnumerator doJump()
    {
        GetComponent<Animation>().Play("idlebattle");
        yield return new WaitForSeconds(0.5f);
        GetComponent<Animation>().Play("idle");
    }
}
