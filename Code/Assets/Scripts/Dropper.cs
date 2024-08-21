using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    Rigidbody rb;
   [SerializeField] float dropValue = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        
       DropStart();

    }

    public void DropStart()
    {
        GetComponent<MeshRenderer>().enabled = false;

        if (Time.timeSinceLevelLoad > dropValue)
        {
            GetComponent<MeshRenderer>().enabled = true;
            rb.useGravity = true;
        }
    }
}
