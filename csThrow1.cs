using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csThrow1 : MonoBehaviour
{
    private void FixedUpdate()
    {
        // The velocity vector of the rigibody.
        // In most cases you should not modify the velocity directly, as this can result in unrealistic behavior.

        if(Input.GetButtonDown("Fire1"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(7, 7, 0);
        }
    }
}
