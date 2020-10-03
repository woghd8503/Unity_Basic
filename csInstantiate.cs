using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Main camera에 추가
// Instantiate를 사용해 Prefab(premade fabrication)을 연속적으로 생성
public class csInstantiate : MonoBehaviour
{
    public Transform firePos;
    public GameObject cannon;

    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Instantiate(cannon, firePos.position, firePos.rotation); // what, where, where
        }
    }
}
