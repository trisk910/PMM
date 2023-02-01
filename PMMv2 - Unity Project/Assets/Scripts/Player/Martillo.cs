using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Martillo: MonoBehaviour
{
    // Start is called before the first frame update

    private GameObject gm ;
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

        if(collision.gameObject.tag == "BoxPalanca")
        {
            gm.GetComponent<GameManager>().showPalanca();
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "BoxMedallonGula")
        {
            gm.GetComponent<GameManager>().showMedallonGulaCaja();
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "BoxMedallonCodiciaM")
        {
            gm.GetComponent<GameManager>().showMedallonCodiciaCaja();
            Destroy(collision.gameObject);
        }

    }
}
