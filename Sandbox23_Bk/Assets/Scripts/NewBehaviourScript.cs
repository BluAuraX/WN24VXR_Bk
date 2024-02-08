using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float turnSpeed = 50f;
    public Vector3 bigScale = new Vector3 (2,2,2);
    public Vector3 smallScale = new Vector3 (1,1,1);




    // Update is called once per frame
    void Update()
    {
        // if the user presses the R key, the material color changes red

        if (Input.GetKeyDown(KeyCode.R))
        {
            GetComponent<Renderer>().material.color = Color.red;
        }
        // ... G changes it to green
        if (Input.GetKeyDown(KeyCode.G))
        {
            GetComponent<Renderer>().material.color = Color.green;
        }
        // ... B changes it to blue
        if (Input.GetKeyDown(KeyCode.B))
        {
            GetComponent<Renderer>().material.color = Color.blue;
        }
        // ... B changes it to purple
        if (Input.GetKeyDown(KeyCode.P))
        {
            GetComponent<Renderer>().material.color = Color.magenta;
        }
        // ... B changes it to white
        if (Input.GetKeyDown(KeyCode.W))
        {
            GetComponent<Renderer>().material.color = Color.white;
        }
        // ... B changes it to black
        if (Input.GetKeyDown(KeyCode.X))
        {
            GetComponent<Renderer>().material.color = Color.black;
        }
        // ... B changes it to grey
        if (Input.GetKeyDown(KeyCode.Z))
        {
            GetComponent<Renderer>().material.color = Color.grey;
        }
        // ... B changes it to yellow
        if (Input.GetKeyDown(KeyCode.Y))
        {
            GetComponent<Renderer>().material.color = Color.yellow;
        }
        // ... B changes it to cyan
        if (Input.GetKeyDown(KeyCode.C))
        {
            GetComponent<Renderer>().material.color = Color.cyan;
        }
        // ... B changes it to clear
        if (Input.GetKeyDown(KeyCode.Q))
        {
            GetComponent<Renderer>().material.color = Color.clear;
        }



        // moves the position
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);
        }
        // scales the size
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.localScale = bigScale;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.localScale = smallScale;
        }


        
    }
}
