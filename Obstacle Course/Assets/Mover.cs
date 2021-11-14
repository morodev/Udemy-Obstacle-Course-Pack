using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    // declare vaiables
    // [SerializeField] float xValue = 0.01f;
    // [SerializeField] float yValue = 0;
    // [SerializeField] float zValue = 0;

    [SerializeField] float moveSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        PrintInstruction();
    }

    // Update is called once per frame
    void Update()
    {
        MovePLayer();
    
    }

    void PrintInstruction()
    {
        Debug.Log("Wlcome to the game!");
        Debug.Log("Move your player with WASD or arrow keys");
        Debug.Log("Don't hit the walls!");
    }

    void MovePLayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue, 0, zValue);

        // use float with f after number 0.05f
        // Es:
        // transform.Translate(0, 0, 0.05f);
    }
}
