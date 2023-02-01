using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LlaveEstrella : MonoBehaviour
{
    private GameObject gm;
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameManager");
    }


    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "cerraduraEstrella")
        {
            gm.GetComponent<GameManager>().enableDoorEstrella();
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}
