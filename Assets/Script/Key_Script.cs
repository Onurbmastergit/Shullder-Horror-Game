using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key_Script : MonoBehaviour
{   
    public AudioSource key_pickup;
    public float speed = 10f;
    void Update()
    {
        transform.Rotate(0,speed * Time.deltaTime,0);
    }
     void OnTriggerEnter(Collider other)
  {
    if(other.CompareTag("Player")){
        key_pickup.Play();
        Door_Outside.key_found = true;
        Door_Inside.key_found = true;
        Destroy(gameObject);
        
    }
  }
}
