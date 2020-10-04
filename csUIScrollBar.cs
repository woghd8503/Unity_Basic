using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;    // 추가 

// Text txtHor / txtVer 에 this script를 추가 하고 scrollbar에 On Value Changed에 txtHor / txtVer를 추가 상위에 있는 UpdateLabel을 tick
public class csUIScrollBar : MonoBehaviour
{
    Text lbl;

    void Start()
    {
        lbl = GetComponent<Text>();
    }

    public void UpdateLabel(float value)                 // 사용자 정의 메서드를 만든다. 스크롤바의 움직임 값을 파라미터로 받을 것이다. 
    {
        if (lbl != null)
            lbl.text = string.Format("{0:0.00}", value); // 스크롤바의 움직임 값을 Text UI의 text 값에 대입해 준다.
    }
}
