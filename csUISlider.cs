using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;       // 추가

// 빈오브젝트를 UIManager로 이름을 변경, this script를 추가
// slider2 conponent에서 On Value Changed추가 ChangeSliderValue 메서드를 호출
public class csUISlider : MonoBehaviour
{
    Text txt;
    Slider slider1;
    Slider slider2;
    int fontSize;

    void Start()
    {
        txt = GameObject.Find("txtCenter").GetComponent<Text>();
        slider1 = GameObject.Find("Slider1").GetComponent<Slider>();
        slider2 = GameObject.Find("Slider2").GetComponent<Slider>();

        fontSize = txt.fontSize;
    }

    public void ChangeSliderValue()
    {
        float val = slider2.value;
        Debug.Log("slider2.value : " + val);

        slider1.value = val;
        txt.fontSize = fontSize + (int)val; // 현재 폰트 사이즈에 슬라이더의 값을 더하여 폰트 사이즈를 늘리거나 줄인다.
    }
}

