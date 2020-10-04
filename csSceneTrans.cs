using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //  SceneManager 추가

// 전환할 두개의 Scenes을 build setting에 add Open Scenes에 추가
// This script를 main camera에 추가
// button에 On Click에 main camera에 있는 method호출 설정
public class csSceneTrans : MonoBehaviour
{
    public void SceneTrans1_1()
    {
        SceneManager.LoadScene("17.LoadSceneEx");
    }

    public void SceneTrans1_2()
    {
        SceneManager.LoadScene("17.LoadSceneEx 1");
    }
}
