using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 두개의 빈오브젝트에다가 this script를 추가 후 실행 Log를 보면 1,2,3,1,2,3으로 출력
public class csCoroutineSubroutine : MonoBehaviour
{
    // Coroutine이란 호출된 함수와 해당 코루틴이 같이 실행되는 구조로 일반 프로그래밍 언어의 쓰레드와 비슷한 개념
    // 하지만 코루틴은 실행을 중지하여 유니티에 제어권을 돌려주고, 그러나 계속할 때는 다음 프레임에서 중지한 곳 부터 
    // 실행을 계속할 수 있는 기능이므로 완전히 독립적인 일을 수행하는 쓰레드와는 또 다른 개념

    // Subroutine은 mainroutine의 반복적인 처리 절차를 수행하기 위해 만든 별도의 함수로 처리 절차가 긑나면 메인르틴의 호출 지점
    // 바로 다음으로 되돌아 간다. 그러므로 Update()에서 Debug.Log()의 호출도 서브루틴의 개념이 성립
    void Start()
    {
        // Debug.Log(gameObject.GetInstanceID());
        Debug.Log(gameObject.name + " : 1 ");
        Debug.Log(gameObject.name + " : 2 ");
        Debug.Log(gameObject.name + " : 3 ");
    }
}
