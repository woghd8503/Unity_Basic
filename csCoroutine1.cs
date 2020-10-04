using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//main camera에 this script 추가

// Synchronous (동기)
/*동기는 함수를 호출하고 호출된 함수의 작업이 완료된 후의 return 을 기다리거나
return 을 받더라도 호출한 함수가 계속해서 작업완료 여부를 신경씀*/

// Asynchronous (비동기)
/*동기는 함수를 호출할 때 callback 함수를 같이 전달해 작업이 완료되면 callback을 실행
작업완료를 callback이 신경씀*/

// Blocking I/O
/*호출된 함수가 자신의 작업을 모두 끝낼때까지 제어권을 가지고 있어 호출한 함수가 대기하도록 만듦*/

// NonBlocking I/O
/*호출된 함수가 바로 return 해서 호출한 함수에게 제어권을 주어 다른 일을 할 수 있게 함 
 *호출되는 함수가 바로 리턴하느냐 마느냐가 중점*/
public class csCoroutine1 : MonoBehaviour
{
    // 비동기 작업이 끝날 대까지 대기

    public string url;                      // http://'를 입력하고 다음에 해당 사이트의 주소를 표시함 * Url에 m.google.com 입력
    WWW www;                                // WWW타입의 변수를 선언한다.

    bool isDownloading = false;

    IEnumerator Start()
    {
        www = new WWW(url);                  // 웹 주소를 이용해 WWW 타입의 객체형을 만든다. 객체를 생성하면서 해당 주소의 내용을 가져오기 시작
        isDownloading = true;
        yield return www;                    // 웹 주소의 내용을 다 가져올 때가지 코루틴의 실행을 멈춤
        isDownloading = false;
        Debug.Log("Download Completed!");    // 웹 주소의 내용을 다 가져오면 로그를 출력
    }

    private void Update()
    {
        if(isDownloading)
        {
            Debug.Log("www.progress");
        }
    }
}
