using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LlaveEstrella : MonoBehaviour
{
    private GameObject gm;
    private AudioSource sonidoCerradura;
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameManager");
        sonidoCerradura = GetComponent<AudioSource>();
    }


    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "cerraduraEstrella")
        {
            gm.GetComponent<GameManager>().enableDoorEstrella();
            sonidoCerradura.Play();
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}
