using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* 캐릭터 컨트롤러 컴포넌트를 추가한 게임 오브젝트는 rigidbody component를 사용하지 않으므로 
 물리 연산을 하지 않는다. 따라서 OnCollisionEnter event나 OnTriggerEnter event가 발생하지 않는다.*/

/*The difference between Rigidbody and Chacter Controller
  캐릭터 컨트롤러는 이동 중에 부딪혀서 멈출 수 있지만, 물리 객체가 아니므로 부딪친 객체를 밀수는 없다.*/

public class csCCcollisionCheck : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("OnCollisionEnter");
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter");
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        // Tag는 하나 이상의 gameobject를 연결하는 단어이다.
        if(hit.collider.gameObject.tag == "WALL")
        {
            Debug.Log("OnControllerColliderHit");
        }
    }
}
