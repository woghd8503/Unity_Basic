using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csKinematic : MonoBehaviour
{
    /* 리지드바디 컴포넌트에 키네마틱을 활성화하면 게임 오브젝트는 물리 엔진에 의해 주되되지 않으며,
    트랜스폼으로만 조작할 수 있게 된다. 즉, 리지드바디 컴포넌트를 포함하고 있지만 AddForce 등으로 힘을 줄 수 없다. */
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter");

        // isKinematic 평소에는 물리를 사용하지 않고 transform을 이용해 움직이다가 특정 상황이 되면, 그때만 물리를 사용.
        GetComponent<Rigidbody>().isKinematic = false;
        GetComponent<Rigidbody>().AddForce(new Vector3(0.0f, 200.0f, -200.0f));
    }
}
