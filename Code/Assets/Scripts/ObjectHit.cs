using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectHit : MonoBehaviour
{
    
    [SerializeField]Color32 wallHit = new Color32(1, 1, 1, 1);

    

    private void Start()
    {
        
    }

    private void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = wallHit;
            gameObject.tag = "Hit";
            
        }
        

    }

   
}
