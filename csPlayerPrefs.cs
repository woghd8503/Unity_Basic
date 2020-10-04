using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;    // 추가

// main camera에 this script를 추가

// 간단하게 데이터를 저장하고 불러올 수 있게 플레이어프렙스(PlayerPrefs)라는 클래스를 제공. 
// 키-밸류(key-value) 형식으로 저장하고 불러온다. 데이터를 저장하기 위해 유니티에서 사용되는
// 변수 타입에 따라 getter 와 setter를 제공하고, 키타 다른 method들도 다음과 같이 제공.
public class csPlayerPrefs : MonoBehaviour
{
    // <이벤트>             /            설명
    //GetFloat                   Preference 파일에 있는 키에 대응하는 값을 반환한다.
    //SetFloat                   키로 식별된 Preference의 값을 설정한다.
    //GetInt                     Preference 파일에 있는 키에 대응하는 값을 반환한다.
    //SetInt                     키로 식별된 Preference의 값을 설정한다.
    //GetString                  Preference 파일에 있는 키에 대응하는 값을 반환한다.
    //SetString                  키로 식별된 Preference의 값을 설정한다.
    //DeleteAll                  키에 대응하는 값을 삭제한다.
    //HasKey                     키가 존재하는지 확인한다.
    //Save                       수정된 모든 Preferences를 디스크에 쓴다.

    private void OnGUI()
    {
        if(GUI.Button(new Rect(30, 50, 180, 30), "Set Value"))
        {
            SetData();
        }

        if(GUI.Button(new Rect(30, 100, 180, 30), "Get Value"))
        {
            GetData();
        }

        void SetData()
        {
            // key / Value
            PlayerPrefs.SetInt("Score", 100);        // playerPrefs class를 이용해 Int 타입의 데이터를 키-밸류 형태로 저장
            PlayerPrefs.SetString("Name", "홍길동");  // playerPrefs class를 이용해 String 타입의 데이터를 키-밸류 형태로 저장
        }

        void GetData()
        {
            // Get Value by key.
            int myScore = PlayerPrefs.GetInt("Score");
            string myName = PlayerPrefs.GetString("Name", "N/A");

            if(EditorUtility.DisplayDialog("알림", "출력할 내용을 선택하세요", "이름", "점수"))
            {
                Debug.Log("Name : " + myName);
            }
            else
            {
                Debug.Log("Score : " + myScore);
            }
        }
    }
}
