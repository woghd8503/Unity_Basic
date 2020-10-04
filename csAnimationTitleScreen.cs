using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// this script를 3D text에 삽입
public class csAnimationTitleScreen : MonoBehaviour
{
    public GUISkin skin;
    private Quaternion originalRotation;
    void Start()
    {
        originalRotation = transform.localRotation;   
    }

    void Update()
    {
        transform.localRotation =              // 타이틀을 계속 좌우로 조금씩 흔든다.
            Quaternion.AngleAxis(Mathf.Sin(2.0f * Time.time) * 20.0f,
            Vector3.up) *
            Quaternion.AngleAxis(Mathf.Sin(2.7f * Time.time) * 33.3f,
            Vector3.right) * originalRotation;

        transform.parent.localRotation =       // 카메라와 타이틀이 포함된 부모 객체를 회전시킨다.
            Quaternion.AngleAxis(Time.deltaTime * 10.0f, Vector3.up) *
            transform.parent.localRotation;
        if(Input.GetButtonDown("Jump"))
        {
            //Application.LoadLevel1("Main");  // 다른 씬으로 전환하는 처리
        }
    }

    private void OnGUI()
    {
        GUI.skin = skin;

        int sw = Screen.width;
        int sh = Screen.height;

        GUI.Label(new Rect(3, 0.6f * sh, sw, 0.4f * sh), "PRESS SPACE TO START", "Title");
    }
}
