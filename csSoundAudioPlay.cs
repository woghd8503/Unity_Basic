using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csSoundAudioPlay : MonoBehaviour
{
    public AudioClip clip;

    void OnCollisionEnter(Collision collision)
    {
        // 오디오 매니저 싱글톤 객체를 가져온 뒤 싱글톤 객체의 PlaySfx 메서드를 호출해 사운드를 출력한다.
        csSoundAudioManager.Instance().PlaySfx(clip);

        Destroy(this.gameObject);
    }
}
