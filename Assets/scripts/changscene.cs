using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changscene : MonoBehaviour
{
    public Material blood;
    public AudioSource splat;

    // Update is called once per frame
    void Update()
    {
        if (CAVE2.GetButtonDown(1, CAVE2.Button.Button3))
        {
            GetComponent<Renderer>().material = blood;
            splat.Play();

        }
    }

}
