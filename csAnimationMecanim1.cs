using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// this script를 모델에 추가
// Blend Tree를 사용해 동작을 세분화함. 왼쪽, 오른쪽, 방향을 자연스럽게 바꿈.
// parameters를 direction과 speed를 설정
public class csAnimationMecanim1 : MonoBehaviour
{
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();    
    }

    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        anim.SetFloat("speed", v);
        anim.SetFloat("direction", h);
    }

    // 이렇게 애니메이터 컨트롤러를 가져와서 컨트롤러 내부에 만들어 놓은 변수에 값을 설정하면
    // 해당 값에 따라 트랜지션의 조건에 맞는 애니메이션이 동작하게 된다.
}
