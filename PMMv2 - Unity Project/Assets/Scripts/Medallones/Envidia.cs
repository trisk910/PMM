using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Envidia : MonoBehaviour
{
    // Start is called before the first frame update

    private GameObject gm;
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameManager");
    }


    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Altar1")
        {
            gm.GetComponent<GameManager>().showMedallonEnvidia();
            Destroy(this.gameObject);
        }
    }
}
