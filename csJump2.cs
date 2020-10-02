using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* gravit 변수의 값이 Update 메서드가 호출될 때마다 줄어들기 때문에 위로 이동하는 거리가 조금씩 줄어든다.
 이는 마치 중력이 작용해 점저 올라가는 속도가 줄어드는 것과 같은 효과를 보인다. 
 gravity 변수의 값이 음수이므로 Y축의 아래 방향으로 이동한다. 즉 내려오는 동작이 된다.*/
public class csJump2 : MonoBehaviour
{
    float gravity = 0.0f; // 중력의 값
    Vector3 velocity;     // 캐릭터의 현재 높이 저장값

    void Start()
    {
        velocity = transform.position;
    }

    void Update()
    {
        // Jump
        if(Input.GetButtonDown("Jump"))
        {
            gravity = 10.0f;
        }

        velocity.y += gravity * Time.deltaTime;

        transform.position = velocity;
        gravity -= 0.5f;

        if(velocity.y < 0.5f)
        {
            velocity.y = 0.5f;
            gravity = 0.0f;
        }
    }
}
