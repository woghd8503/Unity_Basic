using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csOnTriggerEnter : MonoBehaviour
{
    /* OnTriggerEnter 이벤트가 발생하는 조건을 정리해 보면 다음과 같다.
     * 1. 두 게임 오브젝트 모두 콜라이더 (Collider)가 있어야 한다.
     * 2. 둘 중 하나는 Rigidbody가 있어야 한다.
     * 3. 둘 중 하나는 콜라이더에 Is Trigger가 체크돼 있어야 한다.
     * 4. 그리고 어느 쪽이 움직이더라도 서로 만나면 이벤트가 발생한다.
     */

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter");
    }
}

