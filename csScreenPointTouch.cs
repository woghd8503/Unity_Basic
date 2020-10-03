using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// main camera에 추가

/* Raycast는 3D 공간인 월드에서 게임 오브젝트 사이의 충돌을 체크하는 데 사용
   ScreenPointToRay는 화면을 터치해 게임 안의 게임 오브젝트를 선택하는 데 사용*/
public class csScreenPointTouch : MonoBehaviour
{
    void Update()
    {
        if (Input.GetButtonUp("Fire1"))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit)) // 레이케스트 충돌체를 찾음
            {
                if (hit.transform.tag.Equals("Enemy"))
                {
                    csRaycastCubeRotate cubeScript = hit.transform.GetComponent<csRaycastCubeRotate>(); 
                    // public으로 선언된 외부 게임 오브젝트의 스크립트에 대한 변수를 선언하고 값을 연결
                    if (cubeScript != null)
                    {
                        cubeScript.RotateByHit(); // 18번 줄에서 연결한 외부 스크립트의 퍼블릭 메서드를 호출
                    }
                }
            }
        }
    }
}
