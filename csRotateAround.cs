using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csRotateAround : MonoBehaviour
{
    Transform obj = null;
    void Start()
    {
        // 찾기
        obj = GameObject.Find("Cube2").transform;
    }

    void Update()
    {
        // 주변 돌기 1
        // transform.RotateAround(Vector3.zero, Vector3.up, 40 * Time.deltatime);

        // 주변 돌기 2
        transform.RotateAround(obj.position, Vector3.up, 40 * Time.deltaTime); 
        // the first parameter is for 중심 위치, Second 회전의 중심이 될 축, Third 속도 

        transform.LookAt(obj);
    }
}
