using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster_Apear : MonoBehaviour
{
  public Collider collision1;
  public AudioSource scream;
void Update()
{

}
  void OnTriggerEnter(Collider other)
  {
    if(other.CompareTag("Player")){
        collision1.enabled = false;
        scream.Play();
    }
  }
}
