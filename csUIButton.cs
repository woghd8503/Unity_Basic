using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;       //추가

// 스크립트가 든 main camera or empty object(UIManager)를 button On Click에 추가
// 버튼 눌렀을 시 public void ChangeText method를 호출

public class csUIButton : MonoBehaviour
{
    GameObject obj;
    Text txt;

    void Start()
    {
        obj = GameObject.Find("txtCenter");
        txt = obj.GetComponent<Text>();
    }
    public void ChangeText()
    {
        txt.text = "홍길동";
    }
}
