using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csRaycastLookAt : MonoBehaviour
{
    public Transform enemy;
    private Transform spPoint;

    RaycastHit hit;
    Vector3 fwd = Vector3.forward;
    void Start()
    {
        spPoint = transform.Find("/Turret/Tower/SpawnPoint");
    }

    void Update()
    {
        transform.LookAt(enemy);

        Debug.DrawRay(spPoint.position, spPoint.forward * 4, Color.red);

        if(Physics.Raycast(spPoint.position, fwd, out hit, 5))
        {
            Debug.Log(hit.collider.gameObject.name);
        }
    }
}
