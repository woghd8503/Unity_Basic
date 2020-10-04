using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// main camera에 추가
public class csAPIRandomEtc : MonoBehaviour
{
    void Start()
    {
        // 범위 제한
        // 현재값이 최대값보다 크면 그 최대값까지만 출력해주고
        // 최소값보다 작으면 그 최소값으로만 출력
        int myVal = 10;

        float nLimit = Mathf.Clamp(myVal, 1, 5);        // 수의 범위를 제한. 즉 현재값이 최대값보다 크면 최대값을 반환
        Debug.Log("Clamps : " + nLimit);                // 현재값이 최소값보다 작으면 최소값을 반환. 값을 최소값과 최대값 사이의 값으로 제한

        // 랜덤값 구하기
        int randomSeedS;
        randomSeedS = (int)System.DateTime.Now.Ticks;   // 난수를 구하기 위한 시드값으로 현재 시간을 사용
        Random.InitState(randomSeedS);                  // 시드값을 설정

        // Random.Range(이상 미만)
        int randomX = Random.Range(5, 10);              // 범위 안의 정수를 구한다.
        Debug.Log("integer : " + randomX);

        float randomY = Random.Range(5.0f, 10.0f);
        Debug.Log("float : " + randomY);
    }
}
