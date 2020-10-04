using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // 추가
using UnityEditor;                 // 추가                     

/*     Event         / Description
 * Awake                컴포넌트에서 가장 먼저 한 번만 호출되는 함수다.(생성자 개념)
 * OnEnable             게임오브젝트가 활성화 될 때 호출된다.
 * Start                처음 프레임을 그리기 전(최초의 Update 전)에 한 번 호출되는 함수
 * Update               프레임마다 호출되어 반복해서 실행되는 함수다.
 * LateUpdate           프레임마다 호출되어 반복해서 실행되는 함수다. 씬에 있는 모든 Update가 실행된 뒤 실행. Update보다 늦게 계산할 때 사용
 * OnDisable            게임 오브젝트가 비활성화될 때 호출된다. Update가 정지된다.(대기 상태) 다시 활성화하면 OnEnable -> Update 순서로 실행
 * OnDestroy            컴포넌트가 삭제될 때 호출. 프레임이 끝나면 메모리가 사라진다.(소멸자 개념)
 */


public class csSceneTrans1 : MonoBehaviour
{
    public void SceneTrans2_1()
    {
        SceneManager.LoadScene("18.LifeCycle");
    }

    public void SceneTrans2_2()
    {
        SceneManager.LoadScene("18.LifeCycle 1");
    }

    private void Awake()
    {
        Debug.Log("Awake : " + EditorApplication.currentScene);
    }

    private void OnEnable()
    {
        Debug.Log("OnEable : " + EditorApplication.currentScene);
    }

    private void Start()
    {
        Debug.Log("Start : " + EditorApplication.currentScene);
    }

    private void FixedUpdate()
    {

    }

    private void Update()
    {
        
    }

    private void OnGUI()
    {
        
    }

    private void OnDisable()
    {
        Debug.Log("OnDisable : " + EditorApplication.currentScene);
    }

    private void OnDestroy()
    {
        Debug.Log("OnDestroy : " + EditorApplication.currentScene);
    }
}

