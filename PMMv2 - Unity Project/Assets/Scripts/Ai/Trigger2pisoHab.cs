using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger2pisoHab : MonoBehaviour
{
    private GameObject gm;
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameManager");
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            gm.GetComponent<GameManager>().demonioCorreHabP2();
            Destroy(this.gameObject);
        }
    }
}
