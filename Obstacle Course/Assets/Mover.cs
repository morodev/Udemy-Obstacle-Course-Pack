using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, (float)0.05);

        // use float with f after number 0.05f
        // Es:
        // transform.Translate(0, 0, 0.05f);
    }
}
