using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// main camera에  this script를 추가

// <Method를 호출하는 세 가지 방법>
// 1. 게임 오브젝트의 스크립트 컴포넌트를 가져와서 메서드를 직접 호출하는 방법                          (21번줄)
// 2. 게임 오브젝트로 메시지를 보내서 메서드를 호출                                                   (30번줄)
// 3. 별도의 게임 오브젝트를 변수로 가져오지 않고도 바로 메서드를 호출 Only for static method availble (38번줄) 


public class csFunctionCallGameManager : MonoBehaviour
{
    GameObject obj = null;

    void Start()
    {
        obj = GameObject.Find("Cube");
    }

    private void OnGUI()
    {
        if (GUI.Button(new Rect(30, 50, 180, 30), "Function Call (public)"))
        {
            // 특정 Object 안에 있는 Script의 메소드 호출
            // 스크립트 클래스 타입의 변수에 스크립트 컴포넌트를 구해와서 값을 할당
            csFunctionCallRotateCube script = obj.GetComponent<csFunctionCallRotateCube>();
            script.Rotate1();
        }

        if (GUI.Button(new Rect(30, 100, 180, 30), "Function Call (Private)"))
        {
            // 메시지 보내기
            // 메시지 전달을 통해 메서드를 호출
            obj.SendMessage("Rotate2", SendMessageOptions.DontRequireReceiver);
        }

        if (GUI.Button(new Rect(30, 150, 180, 30), "Static"))
        {
            // static 함수나 변수는 바로 접근 가능
            // static 변수를 출력
            Debug.Log("Call Variable : " + csFunctionCallRotateCube.numX);
            // static method를 통해 static method를 호출
            Debug.Log("Call Function : " + csFunctionCallRotateCube.AddTwoNum(3, 5));
        }
    }
}