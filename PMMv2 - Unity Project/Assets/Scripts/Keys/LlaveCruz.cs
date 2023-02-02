using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LlaveCruz : MonoBehaviour
{
    // Start is called before the first frame update

    private GameObject gm;
    private AudioSource sonidoCerradura;
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameManager");
        sonidoCerradura = GetComponent<AudioSource>();
    }


    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "cerraduraCruz")
        {
            gm.GetComponent<GameManager>().hideLlaveCruz();
            sonidoCerradura.Play();
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}
