using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battery_3D : MonoBehaviour
{
    public float speed = 10f;
    void Update()
    {
        transform.Rotate(0,0,speed*Time.deltaTime);

    }
      void OnTriggerEnter(Collider other)
  {
    if(other.CompareTag("Player")){
        Cellphone.battery += 10;
        Destroy(gameObject);
    }
  }
}
