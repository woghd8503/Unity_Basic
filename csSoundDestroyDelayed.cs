using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csSoundDestroyDelayed : MonoBehaviour
{
    private AudioSource myAudio; // 변수를 private으로 선언했으므로 public으로 선언했을 때와 다르게 inspect view에 변수가 없음.
                                 // private나 public 중 아무것도 지정하지 않으면 기본값은 private이다. 
    void Start()
    {
        myAudio = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collision)
    {
        myAudio.Play();

        // 지정한 게임 오브젝트를 게임에서 제거한다.
        Destroy(this.gameObject, myAudio.clip.length);
    }
}
