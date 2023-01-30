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
        if(followPlayer)
            nav.destination = follow.transform.position;
        else
            nav.destination = this.transform.position;

        DemonStates();

    }
    public void DemonStates()
    {
        if (state == "idle")
        {
            nav.speed = 0;
            followPlayer = false;
        }
        if(state == "follow")
        {
            nav.speed = demonSpeed;
            followPlayer = true;
        }
        if(state == "attack")
        {

        }
        if(state == "disappear")
        {//poner sonido de grito i desactivar
            followPlayer = false;
        }

    }
}
