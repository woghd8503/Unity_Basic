using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/* PlayOneShot method는 audio clip을 parameter를 받아서 출력하므로
 * Play method처럼 오디오 소스에 미리 지정된 사운드를 출력할 수도 있지만,
 * 출력하지 전에 오디오 클립 변수인 clip의 값을 변경해 사운드를 출력할 때마다
 * 다른 오디오 클립을 출력할 수도 있다.*/
public class csSoundPlayOneShot : MonoBehaviour
{
    public AudioClip clip;

    private void OnCollisionEnter(Collision collision)
    {
        // GetComponent<AudioSource>().PlayOneShot(clip);
        GetComponent<AudioSource>().PlayOneShot(clip, 0.8f); // 오디오 클립을 출력할 때 사운드 크기를 지정
    }
}
