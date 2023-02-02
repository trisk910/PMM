using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger1pisoGaraje : MonoBehaviour
{
    private GameObject gm;
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameManager");
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            gm.GetComponent<GameManager>().demonioCorreGarajeP1();
            Destroy(this.gameObject);
        }
    }
}
