using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {                  
            GetComponent<MeshRenderer>().material.color = Color.red;           
            // collision.gameObject.tag = "Hit";

        }       
    }
}
