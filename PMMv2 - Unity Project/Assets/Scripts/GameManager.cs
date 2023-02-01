using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Llaves
    public GameObject llaveCruz;
    public GameObject CruzDoorHandlerCruz1;
    public GameObject CruzDoorHandlerCruz2;

    public GameObject CruzDoorHandlerEstrella1;
    public GameObject CruzDoorHandlerEstrella2;

    public GameObject CruzDoorHandler6661;
    public GameObject CruzDoorHandler6662;


    //Medallones
    public GameObject Envidia;
    public GameObject Codicia;
    public GameObject Gula;
    public GameObject Ira;
    public GameObject Lujuria;
    public GameObject Orgullo;    
    public GameObject Pereza;

    //Medallones dentro de cajas
    public GameObject mCajaOrgullo;
    public GameObject mCajaGula;
    public GameObject mCajaPereza;
    public GameObject mCajaCodicia;   

    //Herramientas
    public GameObject Palanca;
    public GameObject Pistola;

    //boleanas MedallonesCompletos
    public bool completeMedallon = false;
    public bool cEnvidia = false;
    public bool cCodicia = false;
    public bool cGula = false;
    public bool cIra = false;
    public bool cLujuria = false;
    public bool cOrgullo = false;
    public bool cPereza = false;

    //Demonio
    public GameObject Demonio;
    public Transform spawnPointPasillo2nPiso;
   
    void Start()
    {
        //Llasves
        llaveCruz.SetActive(false);
        CruzDoorHandlerCruz1.GetComponent<BoxCollider>().enabled = false;
        CruzDoorHandlerCruz2.GetComponent<BoxCollider>().enabled = false;
        CruzDoorHandlerEstrella1.GetComponent<BoxCollider>().enabled = false;
        CruzDoorHandlerEstrella2.GetComponent<BoxCollider>().enabled = false;
        CruzDoorHandler6661.GetComponent<BoxCollider>().enabled = false;
        CruzDoorHandler6662.GetComponent<BoxCollider>().enabled = false;

        //Medallones
        Envidia.SetActive(false);
        Codicia.SetActive(false);
        Gula.SetActive(false);
        Ira.SetActive(false);
        Lujuria.SetActive(false);
        Orgullo.SetActive(false);
        Pereza.SetActive(false);

        //Medallones dentro de cajas
        mCajaOrgullo.SetActive(false);
        mCajaGula.SetActive(false);
        mCajaPereza.SetActive(false);
        mCajaCodicia.SetActive(false);

        //Herramientas
        Palanca.SetActive(false);
        Pistola.SetActive(false);

        //Demonio
        //Demonio.SetActive(false);
    }


    void Update()
    {
    
    }
    
    //Funciones Llaves
    public void showLlaveCruz()
    {
        llaveCruz.SetActive(true);
    }
    public void hideLlaveCruz()
    {
        CruzDoorHandlerCruz1.GetComponent<BoxCollider>().enabled = true;
        CruzDoorHandlerCruz2.GetComponent<BoxCollider>().enabled = true;
    }
    public void enableDoorEstrella()
    {
        CruzDoorHandlerEstrella1.GetComponent<BoxCollider>().enabled = true;
        CruzDoorHandlerEstrella2.GetComponent<BoxCollider>().enabled = true;
    }
    public void enableDoor666()
    {
        CruzDoorHandler6661.GetComponent<BoxCollider>().enabled = true;
        CruzDoorHandler6662.GetComponent<BoxCollider>().enabled = true;
    }

    //Funciones Medallones
    public void showMedallonEnvidia()
    {
        Envidia.SetActive(true);
        cEnvidia = true;
    }

    public void showMedallonCodicia()
    {
        Codicia.SetActive(true);
        cCodicia = true;
    }
    public void showMedallonGula()
    {
        Gula.SetActive(true);
        cGula= true;
    }
    public void showMedallonIra()
    {
        Ira.SetActive(true);
        cIra = true;
    }
    public void showMedallonLujuria()
    {
        Lujuria.SetActive(true);
        cLujuria = true;
    }
    public void showMedallonOrgullo()
    {
        Orgullo.SetActive(true);
        cOrgullo= true;
    }
    public void showMedallonPereza()
    {
        Pereza.SetActive(true);
        cPereza= true;
    }

    //Funciones Cajas
    public void showPalanca()
    {
        Palanca.SetActive(true);
    }

    public void showMedallonOrgulloCaja()
    {
        mCajaOrgullo.SetActive(true);
    }
    public void showMedallonGulaCaja()
    {
        mCajaGula.SetActive(true);
    }
    public void showMedallonPerezaCaja()
    {
        mCajaPereza.SetActive(true);
    }
    public void showMedallonCodiciaCaja()
    {
        mCajaCodicia.SetActive(true);
    }
    public void showPistola()
    {
        Pistola.SetActive(true);
    }

    //Demonio
    public void demonioCorrePasillo()
    {
        //Demonio.SetActive(true);
        GameObject DemonClone = Instantiate(Demonio, spawnPointPasillo2nPiso.position, transform.rotation);
        DemonClone.GetComponent<Ai>().setDemonState("follow");
       // Demonio.transform.position = spawnPointPasillo2nPiso.transform.position;

    }
}
