using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    // Mass는 물질이 가지고 있는 고유한 물리량을 일컫는다.
    // SI 단위는 kg으로 일상생활에서 무게를 통해 쉽게 느낄 수 있는 매우 기초적인 물리량이다.
public class csJump : MonoBehaviour
{
    private void FixedUpdate()
    {
        if(Input.GetButtonDown("Jump"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, 10, 0);

            // 힘을 받은 것이 아니고 속도를 설정한 것이므로 gameobject's mass dose not effect on height of jump.
        }
    }
}
