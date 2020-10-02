using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csIdentity : MonoBehaviour
{
    public float rotSpeed = 120.0f;

    void Update()
    {
        // 씬 뷰의 큐브를 선택하고 게임 뷰에서 화면을 클릭해
        // 씬 뷰에 있는 큐브의 기즈모를 통해 확인

        // 회전
        float amtRot = rotSpeed * Time.deltaTime;
        float ang = Input.GetAxis("Horzontal");
        transform.Rotate(Vector3.up * ang * amtRot);

        // 정렬
        // 월드 좌표 도는 부모 축에 완벽히 정렬
        if(Input.GetButtonDown("Fire1"))
        {
            // transform.rotation = Quaternion.identity;
            transform.localRotation = Quaternion.identity;
        }
    }
}
