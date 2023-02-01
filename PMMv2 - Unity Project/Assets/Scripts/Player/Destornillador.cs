using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destornillador : MonoBehaviour
{
    private GameObject gm;
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameManager");
    }


    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "BoxLlaveCruz")
        {
            gm.GetComponent<GameManager>().showLlaveCruz();
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "BoxPistola")
        {
            gm.GetComponent<GameManager>().showPistola();
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "BoxMedallonCodiciaD")
        {
            Destroy(other.gameObject);
        }
    }

}
