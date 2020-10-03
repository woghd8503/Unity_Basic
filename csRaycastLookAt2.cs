using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csRaycastLookAt2 : MonoBehaviour
{
    public Transform enemy;
    private Transform viewer;
    private Transform spPoint;

    RaycastHit hit;
    Vector3 fwd = Vector3.forward;
    void Start()
    {
        viewer = transform.Find("/Turret/Viewer");
        spPoint = transform.Find("/Turret/Tower/SpawnPoint");
    }

    void Update()
    {
        //      transform.LookAt(enemy);
        viewer.LookAt(enemy);
        transform.rotation = viewer.rotation;

        Vector3 newSpPoint = new Vector3(spPoint.position.x, viewer.transform.position.y, spPoint.position.z);

        //      Debug.DrawRay(spPoint.position, spPoint.forward * 4, Color.red);

        fwd = transform.TransformDirection(viewer.transform.forward);

        //      if (Physics.Raycast(spPoint.position, fwd, out hit, 4))
        if(Physics.Raycast(newSpPoint, fwd, out hit, 4))
        {
            Debug.Log(hit.collider.gameObject.name);
        }
    }
}
