using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csRotate1 : MonoBehaviour
{
    float speed = 50.0f;

    void Update()
    {
        // 키보드 입력
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        // 이동 거리 보정
        h = h * speed * Time.deltaTime;
        v = v * speed * Time.deltaTime;

        // 회전 #1
        // transform.Rotate(Vecter3.forward * h); // Horizontal - Z axis
        // transform.Rotate(Vector3.right * v);   // Vertizl - X axis

        // 회전 #2
        // Horizontal - Z axis
        transform.rotation *= Quaternion.AngleAxis(h, Vector3.forward);
        // Vertical - X axis
        transform.rotation *= Quaternion.AngleAxis(v, Vector3.right);
    }
}
