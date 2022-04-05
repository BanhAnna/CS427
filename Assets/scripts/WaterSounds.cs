using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class WaterSounds : MonoBehaviour
{
     public AudioSource oofSource;
     
     void OnCollisionEnter (Collision collision) {
         if (collision.gameObject.tag == "Water") {
             oofSource.Play ();
         }
     }
    
}
