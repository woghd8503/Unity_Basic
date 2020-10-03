using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csRaycastScreenPointToRay : MonoBehaviour
{

    void Update()
    {
        if(Input.GetButtonUp("Fire1"))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit)) // 12번 줄에서 구한 레이 정보로 레이캐스팅
            {
                Vector3 newPos = new Vector3(hit.point.x, transform.position.y, hit.point.z);
                transform.position = newPos;  // 새로운 벡터값의 위치로 탱크를 이동
            }
        }
    }
}
