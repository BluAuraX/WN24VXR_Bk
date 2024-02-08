using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformPosition1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        foreach (Transform child in transform)
        {
            child.position += Vector3.right * 0.03f;
        }
    }
}
