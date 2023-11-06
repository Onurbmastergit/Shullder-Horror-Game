using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cellphone : MonoBehaviour

{
      public GameObject cam;
     bool on = true;

    void Update()
    {


     if(Input.GetKeyDown(KeyCode.E)){
        on = !on;

     }
        
    GetComponent<MeshRenderer>().enabled = on;
    }
}
