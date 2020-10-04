using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//main camera에 this script 추가

// <코루틴 사용법 정리>
/* 코루틴용 데이터                             /    엔진이 수행하는 기능 
 * yield return null                            다음 프레임까지 대기
 * yield return new WaitForSeconds(float)       지정한 초만큼 대기
 * yield return new WaitForFixedUpdate()        다음 물리 프레임까지 대기
 * yield return new WaitForEndOfFrame()         모든 렌더링 작업이 끝날 때까지 대기
 * yield return StartCoRoutine(string)          다른 코루틴이 끝날 때까지 대기
 * yield return new WWW(string)                 웹 통신 작업이 끝날 때까지 대기
 * yield return new AsyncOperation              비동기 작업이 끝날 때까지 대기(씬로딩)
 */

public class csCoroutine2 : MonoBehaviour
{
    // 비동기 작업이 끝날때까지 대기
    public string url;                   // http://'를 입력하고 다음에 해당 사이트의 주소를 표시함 * Url에 m.google.com 입력
    WWW www;                             // WWW타입의 변수를 선언한다.

    IEnumerator Start()
    {
        www = new WWW(url);              // 웹 주소를 이용해 WWW 타입의 객체형을 만든다. 객체를 생성하면서 해당 주소의 내용을 가져오기 시작
        StartCoroutine("CheckProgress"); // 웹의 데이터를 가졍는 과정을 살펴보기 위해서 또 다른 코루틴 메서드를 호출
        yield return www;                // 웹 주소의 내용을 다 가져올 때까지 Start 코루틴의 실행을 멈춘다.
        Debug.Log("Download completed!");// 웹 주소의 내용을 다 가져오면 로그를 출력
    }

    IEnumerator CheckProgress()         // 웹의 데이터를 가져오는 과정을 살펴보기 위한 코루틴
    {               
        Debug.Log("A: " + www.progress);    
        while(!www.isDone)              // 웹의 데이터를 다 가져왔는지 체크
        {
            yield return new WaitForSeconds(0.5f); // 데이터를 다 가져오면 0.5초 대기
            Debug.Log("B: " + www.progress);       // www 변수의 상태를 출력
        }
    }
}
