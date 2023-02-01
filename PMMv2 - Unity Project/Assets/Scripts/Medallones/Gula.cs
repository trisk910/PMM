using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gula : MonoBehaviour
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
            gm.GetComponent<GameManager>().showMedallonGula();
            Destroy(this.gameObject);
        }
    }
}
