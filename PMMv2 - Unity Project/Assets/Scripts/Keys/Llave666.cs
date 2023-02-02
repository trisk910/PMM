using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Llave666 : MonoBehaviour
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
        if (other.gameObject.tag == "cerradura666")
        {
            gm.GetComponent<GameManager>().enableDoor666();
            sonidoCerradura.Play();
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}
