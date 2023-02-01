using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Llave666 : MonoBehaviour
{
    private GameObject gm;
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameManager");
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "cerradura666")
        {
            gm.GetComponent<GameManager>().enableDoor666();
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}
