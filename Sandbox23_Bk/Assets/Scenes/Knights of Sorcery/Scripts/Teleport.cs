using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
   public Transform teleporttarget;
   

    private void OnTriggerEnter(Collider other)
    {
     
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player position: " + other.transform.position + "\n" + "Target position: " + teleporttarget.transform.position);
            other.transform.position = new Vector3(0, 0, 0);
           // other.transform.position = teleporttarget.transform.position;
        }
    }

}