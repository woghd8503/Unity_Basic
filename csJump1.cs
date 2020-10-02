using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csJump1 : MonoBehaviour
{
    Vector3 velocity = new Vector3(0.0f, 400.0f, 0.0f);

    void FixedUpdate()
    {
        if(Input.GetButtonDown("Jump"))
        {
            // AddForce 메서드는 총탄이나 포탄, 공 등을 움직일 때 편하지만, 중간에 멈추지 못함. 그래서 velocity를 사용해서 움직임을 멈춤.
            // 질량이 2배인 Cube (1)은 같은 힘을 받아도 적게 점프한다.
            GetComponent<Rigidbody>().AddForce(velocity);
        }
    }
}
