using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csAccelerometerKeyMove : MonoBehaviour
{
    void Update()
    {
        // Horizontal - Z axis
        transform.rotation *= Quaternion.AngleAxis(Input.GetAxis("Horizontal") * 30.0f * -1 * Time.deltaTime, Vector3.forward);

        // Vertical - X axis
        transform.rotation *= Quaternion.AngleAxis(Input.GetAxis("Vertical") * 30.0f * -1 * Time.deltaTime, Vector3.left);
    }
}
