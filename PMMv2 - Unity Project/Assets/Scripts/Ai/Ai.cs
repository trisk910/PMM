using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.AI;

public class Ai : MonoBehaviour
{
    public Transform follow;

    private NavMeshAgent nav;
    public float demonSpeed = 3.5f;
    public string state = "idle";
    private bool followPlayer;
    private Animator anim;
    void Start()
    {
        nav = GetComponent<UnityEngine.AI.NavMeshAgent>();
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        if (followPlayer)
            nav.destination = follow.transform.position;
        else
            nav.destination = this.transform.position;

        DemonStates();

    }
    public void setDemonState(string state)
    {
        this.state = state;
    }
    public void DemonStates()
    {
        if (state == "idle")
        {
            nav.speed = 0;
            anim.SetBool("isWalking", false);
            followPlayer = false;
        }
        if (state == "follow")
        {
            nav.speed = demonSpeed;
            anim.SetBool("isWalking", true);      
           
            followPlayer = true;
            StartCoroutine(StopFollow());
        }
        if (state == "attack")
        {
            anim.SetBool("isAttacking", true);
            anim.SetBool("isAttacking", false);
        }
        if (state == "disappear")
        {//poner sonido de grito i desactivar
            followPlayer = false;
            StartCoroutine(Disappear());
        }
    }
    private IEnumerator StopFollow()
    {
        yield return new WaitForSeconds(10.0f);
        setDemonState("disappear");
    }
    private IEnumerator Disappear()
    {
        yield return new WaitForSeconds(2.0f);
        this.gameObject.SetActive(false);
    }
}
