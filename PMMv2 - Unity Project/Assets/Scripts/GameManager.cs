using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    public bool cEnvidia = false;
    public bool cCodicia = false;
    public bool cGula = false;
    public bool cIra = false;
    public bool cLujuria = false;
    public bool cOrgullo = false;
    public bool cPereza = false;

    private int medallonCounter = 0;

    //Demonio
    public GameObject Demonio;
    public Transform spawnPointPasillo2nPisoPasillo;
    public Transform spawnPointPasillo2nPisoHab;
    public Transform spawnPoint1erPisoGaraje;
    public Transform spawnPoint1erPisoCocina;
    public Transform spawnPoint1erPisoBanyo;

    public Transform LastSpawn;

    public int ammo = 0;
   
    void Start()
    {
        //Llaves
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
        if (cCodicia && cEnvidia && cGula && cIra && cLujuria && cOrgullo && cPereza)
            winGame();
        if(medallonCounter == 6)
        {
            demonioLastRespawn();
        }
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
        medallonCounter++;
    }

    public void showMedallonCodicia()
    {
        Codicia.SetActive(true);
        cCodicia = true;
        medallonCounter++;
    }
    public void showMedallonGula()
    {
        Gula.SetActive(true);
        cGula= true;
        medallonCounter++;
    }
    public void showMedallonIra()
    {
        Ira.SetActive(true);
        cIra = true;
        medallonCounter++;
    }
    public void showMedallonLujuria()
    {
        Lujuria.SetActive(true);
        cLujuria = true;
        medallonCounter++;
    }
    public void showMedallonOrgullo()
    {
        Orgullo.SetActive(true);
        cOrgullo= true;
        medallonCounter++;
    }
    public void showMedallonPereza()
    {
        Pereza.SetActive(true);
        cPereza= true;
        medallonCounter++;
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

    //Demonio Spawns
    public void demonioCorrePasilloP2()
    {
        GameObject DemonClone = Instantiate(Demonio, spawnPointPasillo2nPisoPasillo.position, transform.rotation);
        DemonClone.GetComponent<Ai>().setDemonState("follow");
    }
    public void demonioCorreHabP2()
    {
        GameObject DemonClone = Instantiate(Demonio, spawnPointPasillo2nPisoHab.position, transform.rotation);
        DemonClone.GetComponent<Ai>().setDemonState("follow");
    }

    public void demonioCorreGarajeP1()
    {
        GameObject DemonClone = Instantiate(Demonio, spawnPoint1erPisoGaraje.position, transform.rotation);
        DemonClone.GetComponent<Ai>().setDemonState("follow");
    }

    public void demonioCorreCocinaP1()
    {
        GameObject DemonClone = Instantiate(Demonio, spawnPoint1erPisoCocina.position, transform.rotation);
        DemonClone.GetComponent<Ai>().setDemonState("follow");
    }

    public void demonioCorreBanyoP1()
    {
        GameObject DemonClone = Instantiate(Demonio, spawnPoint1erPisoBanyo.position, transform.rotation);
        DemonClone.GetComponent<Ai>().setDemonState("follow");
    }

    public void demonioLastRespawn()
    {
        GameObject DemonClone = Instantiate(Demonio, spawnPoint1erPisoBanyo.position, transform.rotation);
        DemonClone.GetComponent<Ai>().LastTime();
        DemonClone.GetComponent<Ai>().setDemonState("follow");
        medallonCounter = 0;
    }


    //Estado Juego
    public void endGame()
    {
       SceneManager.LoadScene(2);
    }
    public void winGame()
    {
        SceneManager.LoadScene(1);
    }

    //Municion Pistola
    public int getAmmo()
    {
        return ammo;
    }
    public void shootAmmo()
    {
        ammo--;
        if (ammo < 0)
            ammo = 0;
    }
    public void addAmmo()
    {
        ammo++;
    }
}
