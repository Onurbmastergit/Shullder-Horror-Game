using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class No_Exit : MonoBehaviour
{
 public Collider collision1;
  public AudioSource close_door;
  public GameObject open;
   public GameObject close;
void Update()
{
}
  void OnTriggerEnter(Collider other)
  {
    if(other.CompareTag("Player")){
        collision1.enabled = false;
        close.SetActive (true);
        open.SetActive (false);
        close_door.Play();
    }
  }
}
