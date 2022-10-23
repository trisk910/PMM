using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorController : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator doorAnim;
    private bool doorOpen = false;
    private void Awake()
    {
        doorAnim = GetComponent<Animator>();
    }
    public void PlayAnimation()
    {
        if (!doorOpen)
        {
            //doorAnim.Play("DoorOpen", 0, 0.0f);
            doorAnim.SetBool("Close", false);
            doorAnim.SetBool("Open", true);
            doorOpen = true;
        }
        else
        {
            //doorAnim.Play("DoorClose", 0, 0.0f);
            doorAnim.SetBool("Close", true);
            doorAnim.SetBool("Open", false);
            doorOpen = false;
        }
    }
     
}
