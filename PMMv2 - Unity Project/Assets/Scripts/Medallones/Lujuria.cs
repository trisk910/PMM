using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lujuria : MonoBehaviour
{
    private GameObject gm;
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameManager");
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Altar2")
        {
            gm.GetComponent<GameManager>().showMedallonLujuria();
            Destroy(this.gameObject);
        }
    }
}
