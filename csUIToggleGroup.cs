using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  // 추가

// 빈오브젝트이름을 ToggleGroup이라고 변경, toggle group script 추가, 2개의 toggle의 자식으로 두고, 
// 자식인 toggle에 Toggle component에서 Group에 ToggleGroup를 추가하고 둘중 하나는 IsOn을 활성, 비활성.
// tgChange1의 On Value Changed (Boolean)에 ToggleGroup을 추가 ChangeText 매서드를 추가.
public class csUIToggleGroup : MonoBehaviour
{
    Text txt;
    Toggle tgChange;

    void Start()
    {
        txt = GameObject.Find("txtCenter").GetComponent<Text>();
        tgChange = GameObject.Find("tgChange1").GetComponent<Toggle>();
    }

    public void ChangeText()
    {
        if(tgChange.isOn)
        {
            txt.text = "Hello World";
        }
        else
        {
            txt.text = "홍길동";
        }
    }
}
