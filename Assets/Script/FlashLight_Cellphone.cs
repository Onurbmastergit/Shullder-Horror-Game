using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight_Cellphone : MonoBehaviour
{
     bool light_on = true;
     public AudioSource sound;

    float battery = 100;
    void Update()
    {
     if(Input.GetKeyDown(KeyCode.F)){
        light_on = !light_on;
        sound.Play();

     }
     if(battery <=0){
      light_on = false;
     }
        
    GetComponent<Light>().enabled = light_on;
    }

}
