using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addLinternaLife : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject LF;
    
    // Update is called once per frame
    public void addBattery()
    {
        LF.GetComponent<LinternaFuncion>().addLifeBattery();
        //sonido
        this.gameObject.SetActive(false);
    }
}
