using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; 


public class PlayerCotroller : MonoBehaviour
{
    //Create a Reference to an InputActionReference variable named jump. Expose it in the Editor.

    //Create a Reference to a float variable named jumpForce.

    //Create a Reference to a RigidBody component.

 

    private void Awake()
    {
        //Get the reference to the Rigidbody component that is in this gameobject (you will need to assign your XrRig a Rigidbody component first, as well as a Capsule Collider).
    }


    void Start()
    {
        //Subscribe the OnJump callback function to the "performed"  event inside the jump action.
     
    }

    //This is the OnJump callbackfunction
    void OnJump(InputAction.CallbackContext context)
    {
      //Jumpimg logic goes here.
       //Apply an upwards force to the rigidbody only if the player is grounded.
    }

    //Create a function named IsGrounded that that returns a bool value.
    //The function uses a Physics.Raycast to test if the player is touching the ground...
    //...by shooting a ray of length 2 (roughly player's height) from the player's position towards the ground.

}