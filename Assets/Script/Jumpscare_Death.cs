using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumpscare_Death : MonoBehaviour
{
    public AudioSource man_scream;
    void OnTriggerEnter(Collider _col){
         if(_col.gameObject.CompareTag("MainCamera")){
           man_scream.Play();
         }
}
}
