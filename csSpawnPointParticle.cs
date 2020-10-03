using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Main camera에 추가 -> Spawn Point와  Explosion 변수 값을 초기화
public class csSpawnPointParticle : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject myParticle;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            DoMyParticle();
        }
    }

    void DoMyParticle ()
    {
        GameObject particleObj = Instantiate(myParticle) as GameObject;
        particleObj.transform.position = spawnPoint.position;

        Destroy(particleObj, 1.0f);
    }
}
