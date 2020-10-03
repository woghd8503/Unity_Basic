using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csSoundPlay : MonoBehaviour
{
    /* AudioListener : 카메라에 있으며, 사운드를 듣는역할. 카메라를 여러대 생성시 경고가 발생
       AudioSource   : 사운드를 발생
       Audio Clip    : 오디오 소스에서 사용하는 오디오 데이터를 오디오 클립이라고 한다. (모노, 스트레오, 멀티채널 8개)지원*/

    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<AudioSource>().Play();
    }
}
