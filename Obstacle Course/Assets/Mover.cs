using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    // declare vaiables
    // [SerializeField] float xValue = 0.01f;
    // [SerializeField] float yValue = 0;
    // [SerializeField] float zValue = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xValue = Input.GetAxis("Horizontal");
        float zValue = Input.GetAxis("Vertical");
        transform.Translate(xValue, 0, zValue);

        // use float with f after number 0.05f
        // Es:
        // transform.Translate(0, 0, 0.05f);
    }
}
