using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seguir_Inimigo : MonoBehaviour
{
    private Animator animInimigo;
    private UnityEngine.AI.NavMeshAgent navMesh;
    private GameObject player;
    public float velocidadeInimigo;


    void Start()
    {
        animInimigo = GetComponent<Animator>();
        navMesh = GetComponent<UnityEngine.AI.NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player");
        navMesh.speed = velocidadeInimigo;

    }


    void Update()
    {
        navMesh.destination = player.transform.position;
        animInimigo.SetBool("walk", true);

        if(Vector3.Distance(transform.position, player.transform.position) < 1.5f);
        {
            navMesh.speed = 0;
            animInimigo.SetBool("atack", true);
            StartCoroutine("ataque");
        }

    }

    IEnumerator ataque()
    {
        yield return new WaitForSeconds(2.8f);
        animInimigo.SetBool("atack", false);
        navMesh.speed = velocidadeInimigo;
    }

}
