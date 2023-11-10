using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jumpscare : MonoBehaviour
{
   public Collider collision1;
  public AudioSource scream;
  public RawImage jumpscare;
void Update()
{
 
}
  void OnTriggerEnter(Collider other)
  {
    if(other.CompareTag("Player")){
        collision1.enabled = false;
        jumpscare.GetComponent<RawImage>().enabled = true;
        scream.Play();
        StartCoroutine(repeat());
    }
  }
  IEnumerator repeat()
  {
    yield return new WaitForSeconds (2.0f);
    jumpscare.GetComponent<RawImage>().enabled = false;
  }
}
