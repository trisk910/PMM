using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger2pisoPasillo : MonoBehaviour
{
    private GameObject gm;
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameManager");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            gm.GetComponent<GameManager>().demonioCorrePasilloP2();
            Destroy(this.gameObject);
        }
    }
}
