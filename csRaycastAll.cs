using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csRaycastAll : MonoBehaviour
{
    private float speed = 5.0f;
    void Update()
    {
        // 이동
        float amtmove = speed * Time.deltaTime;
        float hor = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * hor * amtmove);

        // DrawRay
        Debug.DrawRay(transform.position, transform.forward * 8, Color.red);

        // RaycastAll
        RaycastHit[] hits;
        hits = Physics.RaycastAll(transform.position, transform.forward, 8.0f);

        // 광선이 충돌한 게임 오브젝트의 이름을 콘솔 창에 전부 출력한다.
        for(int i = 0; i< hits.Length; i++)
        {
            RaycastHit hit = hits[i];

            Debug.Log(hit.collider.gameObject.name);
        }
    }
}
