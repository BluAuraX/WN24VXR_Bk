using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimControl : MonoBehaviour
{
    public GameObject bruce;

    void Update()
    {
        if (Input.GetButtonDown("F"))
        {
            bruce.GetComponent<Animator>().Play("Flying Bicycle Kick");
        }
        if (Input.GetButtonDown("G"))
        {
            bruce.GetComponent<Animator>().Play("Mma Kick");
        }
        if (Input.GetButtonDown("H"))
        {
            bruce.GetComponent<Animator>().Play("Hurricane Kick");
        }
        if (Input.GetButtonDown("B"))
        {
            bruce.GetComponent<Animator>().Play("Fireball");
        }

    }
}
