using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventario : MonoBehaviour
{

    bool showInventory = false;
    // listar todos os paineis de itens
    public Texture espada;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
        if( Input.GetKeyDown(KeyCode.I) ){
            showInventory = !showInventory;
            gameObject.GetComponent<Canvas>().enabled = showInventory;
        }
    }

    public void pegarItem( string nome ){
        if( nome == "espada" ){
            GameObject.Find("slot_1").transform.Find("RawImage").GetComponent<RawImage>().enabled = true;
            GameObject.Find("slot_1").transform.Find("RawImage").GetComponent<RawImage>().texture = espada;
        }
        
    }

}