using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// main camera에 this script 추가
// 첫 번째 log가 찍히고 2초 후 두 번째 로고가 출력
// 일반 프로그래밍 언어에서 Thread.Sleep처럼 원하는 시간이 지나면 실행되는 코드를 코루틴을 이용해 만듬
public class csCoroutine : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            StartCoroutine("Exam1");  // StartCoroutine 메서드를 이용해 코루틴 메서드를 호출
        }
    }
    IEnumerator Exam1()              // 코루틴 메서드의 반환형은 IEnumerator다
    {
        // 이번 렌더링이 끝난 후 실행하고자 할 때
        yield return new WaitForEndOfFrame();

        // 실행하고자 하는 함수난 코드;
        FirstCall();

        // 지정한 시간이 지난 후 실행하고자 할 때
        yield return new WaitForSeconds(2.0f); // 2초 후에 이후의 코드가 실행된다. 

        // 실행하고자 하는 함수나 코드
        SecondCall();
    }

    void FirstCall()
    {
        Debug.Log("First ");
    }

    void SecondCall()
    {
        Debug.Log("Second ");
    }
}
