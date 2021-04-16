using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionControl : MonoBehaviour
{
    public Rigidbody Body;
    
    public readonly float Propel = 1.1f;
    
    // Start is called before the first frame update
    void Start()
    {
        Body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
            Body.AddRelativeForce(Vector3.forward * Propel);
        
        if(Input.GetKeyDown(KeyCode.A))
            Body.AddRelativeForce(Vector3.left * Propel);

        if(Input.GetKeyDown(KeyCode.D))
            Body.AddRelativeForce(Vector3.right * Propel);
        
        if(Input.GetKeyDown(KeyCode.S))
            Body.AddRelativeForce(Vector3.down * Propel);
    }
}
