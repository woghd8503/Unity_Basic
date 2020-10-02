using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csThrow : MonoBehaviour
{
    float power = 800.0f;
    Vector3 velocity = new Vector3(0.5f, 0.5f, 0.0f);

    // If you want to apply a foce over several frames
    // you should apply it inside FixedUpdate instead of Update

    void FixedUpdate()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            GetComponent<Rigidbody>().AddForce(velocity * power);
        }
    }
}
