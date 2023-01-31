using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LlaveCruz : MonoBehaviour
{
    // Start is called before the first frame update

    private GameObject gm;
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameManager");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

 
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "cerraduraCruz")
        {
            gm.GetComponent<GameManager>().hideLlaveCruz();
        }
    }
}
