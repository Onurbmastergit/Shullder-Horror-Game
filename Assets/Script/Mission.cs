using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Mission : MonoBehaviour
{
   public TextMeshProUGUI textoTela;
   public GameObject document;

    bool mission_take_documents = true;

   public static int documents_take = 0;
    int documents_objt = 5;

    bool hud_mission = true;

    void Update(){ 

        if(Input.GetKeyDown(KeyCode.T)){
           hud_mission  =!hud_mission;
           Debug.Log("uuuuuuuuuuu");
        }
         if( mission_take_documents == true){
            textoTela.text = "<b>Descubra a Historia do Hospício<b>\n"+documents_take+"/"+documents_objt;
            if(documents_take >= documents_objt){
                mission_take_documents = false;
            }
        }
    textoTela.GetComponent<TextMeshProUGUI>().enabled = hud_mission;
    }

  
}
