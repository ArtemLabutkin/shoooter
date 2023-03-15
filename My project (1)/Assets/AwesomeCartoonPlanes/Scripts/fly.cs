using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fly : MonoBehaviour
{
    float vertical_1 = 0;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") * 10f;
        float vertical = Input.GetAxis("Vertical") * 10f;
        float rotate = Input.GetAxis("rotate") * 10f;
        float speed = Input.GetAxis("speed")+ 1f;
        if (rb != null)
        {
            rb.AddRelativeForce(new Vector3(0, 0, speed * vertical_1), ForceMode.Force);
            rb.AddRelativeTorque(new Vector3(-vertical, rotate, -horizontal));
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            if(vertical_1 > 0)
            {
                vertical_1 = 0;
            }
            else
            {
                vertical_1 = 100;
            }
        }
    }
}
