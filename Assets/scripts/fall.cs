using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fall : MonoBehaviour
{
    public AudioSource impactSound;
    // Start is called before the first frame update
    void OnCollisionEnter(Collision collision)
    {
        if(collision.relativeVelocity.magnitude > 1)
        {
            impactSound.time = .5f;
            impactSound.Play();
        }
    }
}
