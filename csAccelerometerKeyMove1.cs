using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csAccelerometerKeyMove1 : MonoBehaviour
{
    // paddle 에 rigidbody를 추가하고, Constraints에 있는 Freeze 옵션을 이용 Position X, Y, Z / Rotation Y를 고정
    void Update()
    {
        /*        // Horizontal - Z axis
                transform.rotation *= Quaternion.AngleAxis(Input.GetAxis("Horizontal") * 30.0f * -1 * Time.deltaTime, Vector3.forward);

                // Vertical - X axis
                transform.rotation *= Quaternion.AngleAxis(Input.GetAxis("Vertical") * 30.0f * -1 * Time.deltaTime, Vector3.left);*/

        Vector3 dir = Vector3.zero;
        dir.x = -Input.acceleration.y;
        dir.y = Input.acceleration.x;
        if (dir.sqrMagnitude > 1)
            dir.Normalize();

        dir *= Time.deltaTime;
        transform.Rotate(dir * 10.0f);
    }
}
