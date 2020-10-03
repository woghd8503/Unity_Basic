using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 소프트웨어 디자인 패턴 중에 singleton이라는 디자인 패턴이 있다. 게임 개발에 많이 사용하는 패턴으로
// 어떤 클래스에 대해 하나의 객체만 생성하고 싶을 대 사용한다. static 변수를 활용해 성생하여,
// 메모리에 늘 하나의 객체만 상주하는 특징이 있다.

/* AudioManager를 MainCamera 또는 empty object(Manager)에 추가한다. 절대 제거되지 않을 곳에 추가한다. 그리고 audiosource component를 추가*/

public class csSoundAudioManager : MonoBehaviour
{
    static csSoundAudioManager _instance = null;
    public static csSoundAudioManager Instance()
    {
        return _instance;
    }

    private void Start()
    {
        if (_instance == null)
            _instance = this;
    }

    public void PlaySfx(AudioClip clip)
    {
        GetComponent<AudioSource>().PlayOneShot(clip);
    }
}
