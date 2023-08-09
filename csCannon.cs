using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Trail Renderer
  포탄이 날라갈 때 특수 효과를 추가. Component -> Effects -> Trail Renderer -> add defualt material*/
public class csCannon : MonoBehaviour
{
    float power = 900.0f;
    Vector3 velocity = new Vector3(0.0f, 0.3f, 0.5f);

    void Start()
    {
        velocity = velocity * power;

        GetComponent<Rigidbody>().AddForce(velocity);
    }

    void FixedUpdate()
    {
        if(this.transform.position.z > 10.0f)
        {
            Destroy(this.gameObject);
        }
    }
    
}
