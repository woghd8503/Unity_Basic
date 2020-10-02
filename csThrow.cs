using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csThrow : MonoBehaviour
{
    float power = 800.0f;
    Vector3 velocity = new Vector3(0.5f, 0.5f, 0.0f);

    // If you want to apply a foce over several frames
    // you should apply it inside FixedUpdate instead of Update
    
    // Update와 다르게 FixedUpdate는 Time.deltaTime 값을 곱할 필요가 없다. 이는 프레임 속도와는 독립적으로 타이머가 호출됨.
    // 대신 Edit -> Project Setting -> Time -> Fixed Timesep 에서 값을 수정해서 원하는 속도를 조절. 
    void FixedUpdate()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            GetComponent<Rigidbody>().AddForce(velocity * power);
        }
    }
}
