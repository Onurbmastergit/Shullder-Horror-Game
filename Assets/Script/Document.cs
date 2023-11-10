using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Document : MonoBehaviour
{
    public GameObject document;
    void OnTriggerEnter(Collider collider){
        if(collider.CompareTag("Player")){
            Mission.documents_take ++ ;
            Seguir_Inimigo.velocidadeInimigo = +3;
           document.SetActive(false);
        }
        
    }
}
