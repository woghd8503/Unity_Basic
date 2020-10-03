using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Game Object에 추가.
public class csGUI : MonoBehaviour
{
    // <카메라 투영방식>
    // Perspective(원근 투영 방식): 시야각을 토대로 삼각형 영역이 확장되면서 화면을 구성하는 방식
    // Orthographic(직교 투영 방식): 설정한 크기 값을 토대로 직사각형 영역이 생성되면서 화면을 구성하는 방식

    // <좌표계>
    // 월드(world) 좌표계: 월드의 중심을 원점(0, 0, 0)으로 하는 3차원 상대 좌표계다.
    // 스크린(Screen) 좌표계: 우리가 보는 기기의 화면 좌표계로 화면의 왼쪽 아래를 원점으로 하는 2차원 절대 좌표계다.
    // GUI(Graphic User Interface)가 화면에 그러지는 위치를 표시하는 좌표계로 화면의 왼쪽 위를 원점으로 하는 2차원 절대 좌표계다.

    GameObject box;
    string sStatus = "";

    void Start()
    {
        box = GameObject.Find("BattleShip");
    }

    void OnGUI() // Update()마다 호출. 한 번 그린 UI가 유지되는 게 아니고 
                //  Update() 메서드가 호출될 때마다 OnGUI() 메서드가 호출되면서 화면에 계속 갱신(시스템에 무리 줌)
    {
        if(GUI.RepeatButton(new Rect(10, 240, 50, 30), "<"))
        {
            sStatus = "왼쪽으로 이동합니다.";

            box.transform.Translate(Vector3.left);
        }
        if(GUI.RepeatButton(new Rect(70, 240, 50, 30), ">"))
        {
            sStatus = "오른쪽으로 이동합니다.";

            box.transform.Translate(Vector3.right);
        }
        if(GUI.RepeatButton(new Rect(400, 240, 50, 30), "Fire"))
        {
            sStatus = "총알이 발사됩니다.";

            GameObject bullet = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            // bullet.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
            bullet.transform.position = box.transform.position;
            bullet.transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
            bullet.name = "bullet";
            bullet.AddComponent<csBullet>();
        }

        GUILayout.Label(sStatus);
    }
}
