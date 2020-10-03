using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csSoundWhenDestroy : MonoBehaviour
{
    /*Play() 메서드는 오디오 소스 컴포넌트의 audioClilp을 출력
      PlayOneShot(audioClip) 메서드는 오디오 소스 컴포넌트 외부에 있는 오디오 클립을 출력*/
    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<AudioSource>().Play();

        // 지정한 게임 오브젝트를 게임에서 제거한다.
        Destroy(this.gameObject);
    }
}

