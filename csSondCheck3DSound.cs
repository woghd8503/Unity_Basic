using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// <3D Sound Settings>
// Spatial Blend 1으로 설정 -> Volume Rolloff는 Linear Rolloff설정 -> Min Distance 5 ~ Max Distance 10
public class csSondCheck3DSound : MonoBehaviour
{
    float speed = 20.0f;

    void Update()
    {
        // 키보드 입력
        float v = Input.GetAxis("Vertical");

        // 이동거리 보정
        v = v * speed * Time.deltaTime;

        // 실제 이동
        transform.Translate(Vector3.forward * v);

        // Play 3D Sound Check
        // In Audio Source, Change Spatial Blend. (2d - 3d)
        if(Input.GetButtonDown("Fire1"))
        {
            GetComponent<AudioSource>().Play();
        }
    }
}
