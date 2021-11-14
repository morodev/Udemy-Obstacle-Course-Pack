using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    private int hits = 0;
    private void OnCollisionEnter(Collision collision)
    {
        hits++;
        Debug.Log("You've bumped into a thind this many times: " + hits);
    }
}
