using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LinternaFuncion : MonoBehaviour
{
    public int maxBatteryPower = 120;//duracion 2m
    public Text batteryIndicator;
    public int currentBattery;
    private Light linternaLight;
    //private OVRGrabbable oVRGrabbable;
    // Start is called before the first frame update
    void Start()
    {
        batteryIndicator.text = maxBatteryPower.ToString();
        currentBattery = maxBatteryPower;
        linternaLight= GetComponent<Light>();
        batteryIndicator = GameObject.Find("LinternaUi").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void drainBattery()
    {
        if (currentBattery > 0)
        {
            currentBattery -=  (int)Time.deltaTime;
            int batteryPercentage =  (maxBatteryPower /100) * currentBattery;
            batteryIndicator.text = batteryPercentage.ToString();
        }
        else
        {
            currentBattery = 0;
            lowBattery();

        }
        
    }

    private void lowBattery()
    {
        linternaLight.intensity = Mathf.PingPong(Time.time, 8);
    }
}
