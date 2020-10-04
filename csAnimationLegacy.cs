using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 애니메이션은 2가지 방식으로 사용 
// 1. 전통적인 방식 (Legacy Type)  : 모델링에 포함된 애니메이션을 재생하는 방식
// 2. 애니메이션과 메카님 (Mecanim) : 휴머노이드 타입과 제너릭 타입에서 애니메이션을 동작하는 방식
public class csAnimationLegacy : MonoBehaviour
{
    bool bFast = false;

    public void doWalk()
    {
        StartCoroutine("coWalk");                       // 두 가지 애니메이션을 연속으로 재생해야 하므로 코루틴으로 메서드를 호출
    }

    IEnumerator coWalk()
    {
        GetComponent<Animation>().Play("walk");
        yield return new WaitForSeconds(1.5f);          // 애니메이션이 플레이되는 0.4초 동안 대기한다.
        GetComponent<Animation>().Play("idle");
    }

    public void doAttack()
    {
        StartCoroutine("coAttack");
    }

    IEnumerator coAttack()
    {
        //GetComponent<Animation>().Play("attack");
        GetComponent<Animation>().CrossFade("attack", 0.2f); // 애니메이션 두 개가 시작하고 끝날 때 0.2초 겹치게한다.
        yield return new WaitForSeconds(1.5f);
        //GetComponent<Animation>().Play("idle");
        GetComponent<Animation>().CrossFade("idle", 0.2f);  // 애니메이션 두 개가 시작하고 끝날 때 0.2초 겹치게한다.
    }

    public void doWalkFast()
    {
        if(bFast)
        {
            bFast = false;

            GetComponent<Animation>().Stop();
            GetComponent<Animation>()["walk"].speed = 1.0f; // walk 애니메이션의 재생 속도를 1.0배로 한다.
            GetComponent<Animation>()["walk"].wrapMode = WrapMode.Once;

            StartCoroutine("coWalk");
        }
        else
        {
            bFast = true;

            GetComponent<Animation>().Stop();
           // GetComponent<Animation>()["walk"].speed = 2.0f; // walk 애니메이션의 재생 속도를 2.0배로 한다.
            GetComponent<Animation>()["run"].speed = 1.0f;
            GetComponent<Animation>()["run"].wrapMode = WrapMode.Loop;
            GetComponent<Animation>().Play("run");
        }
    }
}
