using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csCCMove : MonoBehaviour
{
    public float movSpeed = 5.0f;
    public float rotSpeed = 120.0f;

    CharacterController controller;
    Vector3 moveDirection;

    float jumpSpeed = 10.0f;    // jump speed
    float gravity = 20.0f;      // gravity
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }


    void Update()
    {
        if(controller.isGrounded)
        {
            float amtRot = rotSpeed * Time.deltaTime;

            float ver = Input.GetAxis("Vertical");
            float ang = Input.GetAxis("Horizontal");

            transform.Rotate(Vector3.up * ang * amtRot);

            moveDirection = new Vector3(0, 0, ver * movSpeed);
            // TransformDirection 함수는 인자 direction을 월드 좌표계 기준으로 변환한 벡터를 반환한다.
            // 로컬 좌표계 기준으로 정의된 방향 벡터 -> 월드 좌표계 기준으로 정의된 방향 벡터
            moveDirection = transform.TransformDirection(moveDirection); 

            if (Input.GetButton("Jump"))
                moveDirection.y = jumpSpeed;
        }

        moveDirection.y -= gravity * Time.deltaTime;

        controller.Move(moveDirection * Time.deltaTime);
    }
}
