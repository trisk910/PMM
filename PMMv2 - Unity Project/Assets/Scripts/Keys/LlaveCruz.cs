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


    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "cerraduraCruz")
        {
            gm.GetComponent<GameManager>().hideLlaveCruz();
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}
