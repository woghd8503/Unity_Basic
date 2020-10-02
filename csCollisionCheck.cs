using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* OnCollisionEnter 이벤트가 발생하는 조건
 1. 두 게임 오브젝트 모두 Collider가 있어야 한다.
 2. 둘 중 하나는 Rigidbody가 있어야 한다.
 3. 그리고 Rigidbody를 가진 쪽이 움지여서 서로 만났을 때만 이벤트가 발생한다.*/
public class csCollisionCheck : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("OnCollisionEnter");
    }
}
