using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  // 추가

// 빈 게임오브젝트를 UImanager로 이름을 변경 후 this script를 추가
public class csUIText : MonoBehaviour
{
    GameObject obj;
    Text txt;

    void Start()
    {
        obj = GameObject.Find("txtCenter");
        txt = obj.GetComponent<Text>();

        ChangeText();
    }

    void ChangeText()
    {
        txt.text = "홍길동";
    }
}
