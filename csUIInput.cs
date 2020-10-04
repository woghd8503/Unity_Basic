using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  // 추가
using UnityEditor;     // For Dialog

public class csUIInput : MonoBehaviour
{
    Text txt;  // Hellow Wold라는 글자를 Input1에 입력한 글자로 변경
    InputField input1;
    InputField input2;
    InputField input3;

    void Start()
    {
        txt = GameObject.Find("txtCenter").GetComponent<Text>();
        input1 = GameObject.Find("InputField1").GetComponent<InputField>();
        input2 = GameObject.Find("InputField2").GetComponent<InputField>();
        input3 = GameObject.Find("InputArea").GetComponent<InputField>();
    }

    public void ChangeValue()
    {
        if (input1.text.Length < 4)          // 사용자의 입력 포커스를 InputField1 으로 지정
        {
            if (EditorUtility.DisplayDialog("알림", "입력은 4자 이상 해주시기 바랍니다.", "확인"))
            {
                input1.Select();
                //input1.ActivateInputField();
            }
        }
        else
        {
            txt.text = input1.text;  // InputField1에 입력받은 문자열을 Text 타입의 변수에 할당
        }

        Debug.Log("InputField1 : " + input1.text);
        Debug.Log("InputField2 : " + input2.text);
        Debug.Log("InputArea : " + input3.text);
    }
}
