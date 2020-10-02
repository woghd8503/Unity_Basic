using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csMove1 : MonoBehaviour
{
    float speed = 20.0f;

    void Update()
    {
        // 키보드 입력
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        // 이동 거리 보정
        h = h * speed * Time.deltaTime;
        v = v * speed * Time.deltaTime;

        // 실제 이동
        transform.Translate(Vector3.right * h);
        transform.Translate(Vector3.forward * v);
        
    }
}
