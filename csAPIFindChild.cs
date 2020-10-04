using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// main camera에 추가
public class csAPIFindChild : MonoBehaviour
{
    public Transform[] SpawnPoint;      // 찾아온 자식 game object의 트랜스폼을 저장할 배열을 선언
    void Start()
    {
                                        // 먼저 SpawnPoint game object를 찾는다. 그다음 자식 객체들의 트랜스폼을 가져와 배열에 담는다. 
        SpawnPoint = GameObject.Find("SpawnPoint").GetComponentsInChildren<Transform>();

        for(int i = 0; i < SpawnPoint.Length; i++)
        {                                               
            Debug.Log(SpawnPoint[i].gameObject.name); // 찾아온 game object의 이름을 출력
        }
    }
}
