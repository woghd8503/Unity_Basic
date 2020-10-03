using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Maincamera나 empty GameObjec에 add this script*/

public class csSoundPlayClipAtPoint : MonoBehaviour
{

    float speed = 20.0f;

    public Transform box;
    public AudioClip myClip;

    void Update()
    {
        // 키보드 입력
        float v = Input.GetAxis("Vertical");

        // 이동거리 보정
        v = v * speed * Time.deltaTime;

        // 실제 이동
        box.transform.Translate(Vector3.forward * v);

        if (Input.GetButtonDown("Fire1"))
        {
            // myClip 오디오 클립을 box.position의 위치에 출력 singleton pattern
            AudioSource.PlayClipAtPoint(myClip, box.position);
        }
    }
}

