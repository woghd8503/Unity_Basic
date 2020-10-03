using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/* Raycast는 광선Ray을 쏴서 지정한 방향과 거리 이내에 부딪히는 게임 오브젝트가 있는지 판단하는 알고리즘
   <Raycast 호출 방식>
    Physics.Raycast(기준점, 방향, hitInfo, 거리)    :가장 가까운 물체 탐색
    Physics.RaycastAll(기준점, 방향, hitInfo, 거리) :전체 탐색
    Physics.Linecast(시작점, 끝점, hitInfo)         :지정한 범위에서 탐색
 */
public class csRaycast : MonoBehaviour
{
    private float speed = 5.0f;

    void Update()
    {
        // 이동
        float amtMove = speed * Time.deltaTime;
        float hor = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * hor * amtMove);

        // DrawRay
        Debug.DrawRay(transform.position, transform.forward * 8, Color.red);

        // Raycast
        RaycastHit hit;
        if(Physics.Raycast(transform.position, transform.forward, out hit))
        {
            Debug.Log(hit.collider.gameObject.name);
        }
    }
}
