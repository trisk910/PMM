using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ira : MonoBehaviour
{
    private GameObject gm;
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameManager");
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Altar1")
        {
            gm.GetComponent<GameManager>().showMedallonIra();
            Destroy(this.gameObject);
        }
    }
}
