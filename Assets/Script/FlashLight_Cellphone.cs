using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight_Cellphone : MonoBehaviour
{
     bool light_on = true;
     public AudioSource sound;
     
    void Update()
    {
     if(Input.GetKeyDown(KeyCode.F)){
        light_on = !light_on;
        sound.Play();

     }
        
    GetComponent<Light>().enabled = light_on;
    }
}
