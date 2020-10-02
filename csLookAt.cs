using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csLookAt : MonoBehaviour
{
    // Capital letter 대문자로 표현하는 것은 변수 타입.
    Transform obj = null;

    void Start()
    {
        // 찾기
        obj = GameObject.Find("Cube2").transform; // Small letter 모든 컴포넌트는 소문자로 표현.
    }
   
    void Update()
    {
        // 주시
        transform.LookAt(obj);
    }
}
