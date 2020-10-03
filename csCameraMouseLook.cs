using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csCameraMouseLook : MonoBehaviour
{
    public float sensitivity = 500.0f;
    public float rotationX;
    public float rotationY;

    void Update()
    {
        // 마우스 좌우로 이동
        float mouseMoveValueX = Input.GetAxis("Mouse X");
        // 마우스 전후로 이동
        float mouseMoveValueY = Input.GetAxis("Mouse Y");

        rotationX += mouseMoveValueX * sensitivity * Time.deltaTime;
        rotationY += mouseMoveValueY * sensitivity * Time.deltaTime;

        // 마우스 앞으로 이동
        if (rotationY > 45.0f)
            rotationY = 45.0f;   // 카메라 방향이 위쩍으로 45도 이상 올라가지 않게 처리
        // 마우스 뒤로 이동
        if (rotationY < -20.0f)
            rotationY = -20.0f; // 카메라 방향이 아래쪽으로 20도 이상 올라가지 않게 처리

        transform.eulerAngles = new Vector3(-rotationY, rotationX, 0.0f);
    }
}
