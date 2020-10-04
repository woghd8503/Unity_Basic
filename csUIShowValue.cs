using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;    //추가

// Slider1 자식의 Label Percent (UI text)에 this script를 추가
// Slider1 component에서 On Value Changed에서 Label Percent를 추가 후 options 위쪽에 있는 UpdateLabel을 호출
// 숫자로 percentage를 나타나기 위해 만든 script
public class csUIShowValue : MonoBehaviour
{
    public void UpdateLabel(float value)
    {
        Text lbl = GetComponent<Text>();
        if(lbl != null)
        {   // 파라미터로 넘어온 값을 이용 수학함수를 이용하여 정수로 만들어 Text UI의 값에 대입
            lbl.text = Mathf.RoundToInt(value * 10) + "%";  
        }
    }
}
