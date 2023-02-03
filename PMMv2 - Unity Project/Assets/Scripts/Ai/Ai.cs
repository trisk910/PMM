using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Rendering;

public class Ai : MonoBehaviour
{
    private GameObject player;

    private GameObject gm;

    private NavMeshAgent nav;
    public float demonSpeed = 0.05f;
    public string state;
    private Animator anim;

    private AudioSource audioSource;
    public AudioClip AudioScream;
    public AudioClip AudioLaugh;

    public float followTimer = 7.0f;
    void Start()
    {
        nav = GetComponent<UnityEngine.AI.NavMeshAgent>();
        anim = GetComponent<Animator>();
        player = GameObject.FindGameObjectWithTag("Player");
        gm = GameObject.FindGameObjectWithTag("GameManager");

        audioSource = GetComponent<AudioSource>();
    }
    void Update()
    {
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
            nav.enabled = false;
            nav.speed = 0;
            anim.SetBool("isWalking", false);
        }
        if (state == "follow")
        {
            nav.enabled = true;
            anim.SetBool("isWalking", true);            
            nav.destination = player.transform.position;
            nav.speed = demonSpeed;
            audioSource.PlayOneShot(AudioLaugh, 0.7f);
            StartCoroutine(StopFollow());
        }
        if (state == "attack")
        {
            anim.SetBool("isAttacking", true);
            anim.SetBool("isAttacking", false);
        }
        if (state == "disappear")
        {//poner sonido de grito i desactivar
            nav.enabled = false;
            nav.speed = 0;
            audioSource.PlayOneShot(AudioScream, 0.4f);
            StartCoroutine(Disappear());
        }
    }
    private IEnumerator StopFollow()
    {
        yield return new WaitForSeconds(followTimer);
        setDemonState("disappear");
    }
    private IEnumerator Disappear()
    {
        yield return new WaitForSeconds(2.0f);
        //this.gameObject.SetActive(false);
        Destroy(this.gameObject);
    }

    public void LastTime()
    {
        followTimer = 30.0f;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            setDemonState("attack");
            gm.GetComponent<GameManager>().endGame();
        }
        if (collision.gameObject.tag == "bullet")
        {
            nav.speed = 0;
            nav.enabled=false;
            anim.SetBool("isWalking", false);
            StartCoroutine(SlowDown());
        }
    }
    private IEnumerator SlowDown()
    {
        yield return new WaitForSeconds(1.5f);
        nav.enabled = true;
        nav.speed = demonSpeed;       
        anim.SetBool("isWalking", true);
    }
}
