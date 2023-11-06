using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Cellphone : MonoBehaviour

{
      public GameObject cam;
     bool on = true;
     public float zoom_max = 30;
      public float zoom_minum = 50;

    void Update()
    {
      if(Input.GetKeyDown(KeyCode.Q)){
        cam.GetComponent<Camera>().fieldOfView = zoom_max;
      }
      if(Input.GetKeyDown(KeyCode.Z)){
        cam.GetComponent<Camera>().fieldOfView = zoom_minum;
      }


     if(Input.GetKeyDown(KeyCode.E)){
        on = !on;

     }
        
    GetComponent<MeshRenderer>().enabled = on;
    }
}
