using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Cube에  this script를 추가
public class csFunctionCallRotateCube : MonoBehaviour
{
    public static int numX = 0;                    // 변수 하나를 static 상수로 선언
    
    public static int AddTwoNum(int x, int y)
    {
        return x + y;
    }

    public void Rotate1()
    {
        transform.Rotate(Vector3.up * 90.0f);      // 오른쪽으로 회전시킨다. 
    }

    public void Rotate2()
    {
        transform.Rotate(Vector3.up * 90.0f * -1);  // 왼쪽으로 회전시킨다. 
    }
}
