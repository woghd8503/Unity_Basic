using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 받은 모델의 inspect창에서 Rig를 Humanoid로 변경
// Asset -> Create -> Animator Controller 생성
// Animator Controller를 모델의 Avartar에 추가
// 애니메이션의 Transition을 설정해 parameter를 int, float, Bool, Trigger로 설정 하고 값을 Equals, Less, Greater, Notequal로 순서 정함
// Has Exit Time을 체크하면 애니메이션이 종료되야 다음 동작으로 전환

// this script를 모델에 직접 추가 후 버튼 설정
// Animator에 Apply Root Motion 옆에 있는 체크 박스를 해제해야지 제자리에서 동작
public class csAnimationMecanim : MonoBehaviour
{
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>(); // 헷갈리지말고 Animation 아니고 Animator 
    }

    public void doIdle()
    {
        anim.SetInteger("aniStep", 0);
    }

    public void doWalk()
    {
        anim.SetInteger("aniStep", 1);
    }

    public void doRun()
    {
        anim.SetInteger("aniStep", 2);
    }

    public void doJump()
    {
        //anim.SetInteger("aniStep", 3);
        StartCoroutine("coJump");
    }

    IEnumerator coJump()
    {
        anim.SetInteger("aniStep", 3);
        yield return new WaitForSeconds(0.8f);
        anim.SetInteger("aniStep", 0);
    }
}
