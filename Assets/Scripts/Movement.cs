using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessThrust();
        ProcessRotation();
    }

    private void ProcessThrust()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            rb.AddRelativeForce(Vector3.up);
        }
    }

    private void ProcessRotation()
    {
        if(Input.GetKey(KeyCode.A))
        {
            Debug.Log("Rotating Left");
        }
        else if(Input.GetKey(KeyCode.D))
        {
            Debug.Log("Rotating Right");
        }
    }
}
