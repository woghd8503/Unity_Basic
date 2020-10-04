using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Cube1에 this script 추가
public class csAPIDistance : MonoBehaviour
{
    public Transform box1;
    public Transform box2;
    public Transform box3;

    void Start()
    {
        // 두 Object 사이의 거리 구하기 1
        float distance1 = Vector3.Distance(transform.position, box2.position);
        Debug.Log("distance1 : " + distance1);

        // 두 Object 사이의 거리 구하기 2
        // 타겟이 항상 앞에 나와야 한다
        float distance2 = (box3.position - transform.position).magnitude;
        Debug.Log("distance2 : " + distance2);

        // 방향 구하기
        Vector3 dir = box2.position - transform.position;
        dir.Normalize(); // 방향은 거리가 필요 없으므로 0~1 사이의 값으로 단위화해서 표시하기 때문에 방향을 구하기 위한 벡터를 구해서 단위화한다.

        // 회전
        transform.eulerAngles = dir;
    }
}
