using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Move는 전,후,좌,우로 이동시켰다. 하지만 자동차의 움직임을 보면 차가 옆으로 이동하지 않는다.*/

public class csMoveAndRotate : MonoBehaviour
{

    public float movSpeed = 5.0f;
    public float rotSpeed = 120.0f;

    void Update()
    {
        float amtMove = movSpeed * Time.deltaTime;
        float amtRot = rotSpeed * Time.deltaTime;

        float ver = Input.GetAxis("Vertical");
        //float hor = Input.GetAxis("Horizontal");
        float ang = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * ver * amtMove);
        //transform.Translate(Vector3.right * hor * amtMove);
        transform.Rotate(Vector3.up * ang * amtRot);
    }
}