using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;
    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Hit"))
        {            
            hits++;
            collision.gameObject.tag = "Hit";
            Debug.Log("You've bumped into a thind this many times: " + hits);
        }
      
    }
}
