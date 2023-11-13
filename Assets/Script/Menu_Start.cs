using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Menu_Start : MonoBehaviour
{
    public string scenename;
    public Animator cam;
    public GameObject starts;

    void Start()
    {
        UnityEngine.Cursor.lockState = CursorLockMode.Locked;
        UnityEngine.Cursor.visible = false;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P)){
             cam.SetTrigger("Starts");
             StartCoroutine(repeat());
             starts.SetActive(false);
        }
    }

   IEnumerator repeat()
  {
    yield return new WaitForSeconds (1.0f);
    SceneManager.LoadScene(scenename);
        
  }
}
