using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csCoroutineYield : MonoBehaviour
{
    // 열거자, 계산자 반환형을 void에서 IEnumerator로 변경하면 유니티 엔진이 자동으로 코루틴을 실행
    IEnumerator Start()  
    {
        Debug.Log(gameObject.name + " : 1 ");
        yield return null;      // 한 프레임을 대기하게 만든다.
        Debug.Log(gameObject.name + " : 2 ");
        Debug.Log(gameObject.name + " : 3 ");
    }
}
