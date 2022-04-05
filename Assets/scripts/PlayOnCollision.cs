using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayOnCollision : MonoBehaviour
{
     
     public AudioClip mySound;
     private void OnTriggerEnter(Collider other){

          AudioSource.PlayClipAtPoint(mySound, transform.position);
          // mySound.Play();
     }
    
}