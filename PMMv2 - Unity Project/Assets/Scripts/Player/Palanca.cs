using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Palanca : MonoBehaviour
{
    private GameObject gm;
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameManager");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "BoxMetalMedallonOrg")
        {
            gm.GetComponent<GameManager>().showMedallonOrgulloCaja();
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "BoxMedallonPereza")
        {
            gm.GetComponent<GameManager>().showMedallonPerezaCaja();
            Destroy(collision.gameObject);
        }
    }
}
