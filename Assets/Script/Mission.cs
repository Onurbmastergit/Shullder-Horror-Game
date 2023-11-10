using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Mission : MonoBehaviour
{
   public TextMeshProUGUI textoTela;
   public GameObject document;

    bool mission_take_documents = true;

    int documents_take = 0;
    int documents_objt = 5;
    void Start()
    {
        checkMission();
    }

    public void checkMission(){
        if( mission_take_documents == true){
            textoTela.text = "<b>Descubra a Historia do Hospício<b>\n"+documents_take+"/"+documents_objt;
            if(documents_take >= documents_objt){
                mission_take_documents = false;
            }
        }
    }

    public void takeDocument(){
        documents_take += 1;
        checkMission();
    }
}
