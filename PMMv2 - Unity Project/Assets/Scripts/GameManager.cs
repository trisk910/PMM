using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject llaveCruz;
    public bool canOpenCruzDoor = false;
    public GameObject CruzDoorHandler1;
    public GameObject CruzDoorHandler2;
    void Start()
    {
        llaveCruz.SetActive(false);
        CruzDoorHandler1.GetComponent<BoxCollider>().enabled = false;
        CruzDoorHandler2.GetComponent<BoxCollider>().enabled = false;
    }

    // Update is called once per frame+

    void Update()
    {
        checkDoorCruzStatus();
    }
    

    public void showLlaveCruz()
    {
        llaveCruz.SetActive(true);
    }
    public void hideLlaveCruz()
    {
        canOpenCruzDoor = true;
        llaveCruz.SetActive(false);
    }
    public void checkDoorCruzStatus()
    {
        if (canOpenCruzDoor)
        {
            CruzDoorHandler1.GetComponent<BoxCollider>().enabled = true;
            CruzDoorHandler2.GetComponent<BoxCollider>().enabled = true;
        }
    }

}
