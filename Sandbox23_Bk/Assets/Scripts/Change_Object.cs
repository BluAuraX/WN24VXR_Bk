using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_Object : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float turnSpeed = 50f;
    public Vector3 bigScale = new Vector3 (2, 2, 2);
    public Vector3 smallScale = new Vector3 (1, 1, 1);


    // function that makes objects bigger
    public void Big()
    {
        transform.localScale = bigScale;
    }

    // function that makes objects bigger
    public void Small()
    {
        transform.localScale = smallScale;
    }

    // function that moves the object


    // functions that change the colors
    public void Red()
        {
            GetComponent<Renderer>().material.color = Color.red;
        }

    public void Blue()
        {
            GetComponent<Renderer>().material.color = Color.blue;
        }

    public void Yellow()
        {
            GetComponent<Renderer>().material.color = Color.yellow;
        }

    public void Green()
        {
            GetComponent<Renderer>().material.color = Color.green;
        }




}
