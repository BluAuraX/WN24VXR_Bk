using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    public AudioSource playSound;

   void OnSelect()
   {
    playSound.Play();
   }
}
