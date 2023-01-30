using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LinternaFuncion : MonoBehaviour
{
    public float maxBatteryPower = 120;//duracion 2m
   // public Text batteryIndicator;
    public float currentBattery;
    public Light linternaLight;
    private bool drainBatteryLight;
    //private OVRGrabbable oVRGrabbable;
    // Start is called before the first frame update
    void Start()
    {
       // batteryIndicator.text = maxBatteryPower.ToString();
        currentBattery = maxBatteryPower;
        linternaLight.enabled = false;
        drainBatteryLight = false;
        //linternaLight= GetComponent<Light>();
        // batteryIndicator = GameObject.Find("LinternaUi").GetComponent<Text>();
    }

    private void Update()
    {
        if (drainBatteryLight)
            drainBattery();
    }

    // Update is called once per frame
    public void turnOffLight()
    {
        linternaLight.enabled = false;
        drainBatteryLight = false;
    }

    public void turnOnLight()
    {
        linternaLight.enabled = true;
        drainBatteryLight = true;
    }

    public void drainBattery()
    {
        if (currentBattery > 0)
        {
            currentBattery -= 1.0f * (Time.deltaTime);
            // float batteryPercentage =  (maxBatteryPower /100) * currentBattery;
            //batteryIndicator.text = batteryPercentage.ToString();
        }
        else
        {
            currentBattery = 0;
            lowBattery();

        }
        
    }

    private void lowBattery()
    {
        linternaLight.intensity = Mathf.PingPong(Time.time, 3);
    }

    public void addLifeBattery()
    {
        this.currentBattery += maxBatteryPower;
    }

}
