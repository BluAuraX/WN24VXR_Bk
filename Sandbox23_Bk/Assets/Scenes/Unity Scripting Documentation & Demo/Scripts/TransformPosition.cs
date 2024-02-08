using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformPosition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // This line makes sure that all of the children will have their coordinates changed as well
        foreach (Transform child in transform)
        {
            // The object will move 0.02 coordinates to the right each frame
            child.position += Vector3.right * 0.02f;
        }
    }
}
