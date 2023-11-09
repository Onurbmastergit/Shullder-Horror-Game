using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_Outside : MonoBehaviour
{
       public Animator _animator;
    private bool _colider;
    private bool _doorOpen = false;
    void Update(){
        _doorOpen = false;
    }
    void OnTriggerEnter(Collider _col){
         if(_col.gameObject.CompareTag("Player")){
            _animator.SetTrigger("Outside");
            Debug.Log("aiii");
            _colider = true;
            _doorOpen = true;
         }
    }
      void OnTriggerExit(Collider _col){
        if(_col.gameObject.CompareTag("Player")){
            if(_doorOpen == false){
                _animator.SetTrigger("Close");
                Debug.Log("abriu3");
            }
            _colider = false;
            Debug.Log("abriu4");
        }
    }

}
