using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    // declare vaiables
    float xValue = 0f;
    float yValue = 0.01f;
    float zValue = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(xValue, yValue, zValue);

        // use float with f after number 0.05f
        // Es:
        // transform.Translate(0, 0, 0.05f);
    }
}
