using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorGrabable : OVRGrabbable
{
    //public Transform handler;
    public GameObject door;
    /*public override void GrabEnd(Vector3 linearVelocity, Vector3 angularVelocity)
    {
        base.GrabEnd(Vector3.zero, Vector3.zero);

        transform.position = handler.transform.position;
        transform.rotation = handler.transform.rotation;
    }*/
    public override void GrabEnd(Vector3 linearVelocity, Vector3 angularVelocity)
    {
        base.GrabEnd(Vector3.zero, Vector3.zero);
        door.gameObject.GetComponent<doorController>().PlayAnimation();
    }
}
