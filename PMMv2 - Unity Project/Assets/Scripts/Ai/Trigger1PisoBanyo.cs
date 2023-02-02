using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger1PisoBanyo : MonoBehaviour
{
    private GameObject gm;
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameManager");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            gm.GetComponent<GameManager>().demonioCorreBanyoP1();
            Destroy(this.gameObject);
        }
    }
}
