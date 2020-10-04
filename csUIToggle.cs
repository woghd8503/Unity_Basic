using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  // 추가

// Toggle은 체크박스 형태로 사용될 수도 있고 라디오버튼 방식으로 사용 됨

// 스크립트가 든 main camera or empty object(UIManager)를 button On Click에 추가
// Toggle을 통해 (On value Changed <Boolean>) text 변화

public class csUIToggle : MonoBehaviour
{
    Text txt;
    Toggle tgChangeText;

    void Start()
    {
        txt = GameObject.Find("txtCenter").GetComponent<Text>();
        tgChangeText = GameObject.Find("tgChangeText").GetComponent<Toggle>();
    }

    public void ChangeText()
    {
        if(tgChangeText.isOn)
        {
            txt.text = "Hello World";
        }
        else
        {
            txt.text = "홍길동";
        }
    }
}
