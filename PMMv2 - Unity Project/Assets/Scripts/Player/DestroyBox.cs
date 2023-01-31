using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBox : MonoBehaviour
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
        if (collision.gameObject.tag == "BoxLlaveCruz")
        {
            gm.GetComponent<GameManager>().showLlaveCruz();
            Destroy(collision.gameObject);           
        }
    }
}
