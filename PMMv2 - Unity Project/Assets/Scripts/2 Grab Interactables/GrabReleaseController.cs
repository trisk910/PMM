using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class GrabReleaseController : MonoBehaviour
{
    private XRController controller;
    private bool isGrabbing = false;
    private GameObject currentHeldObject;

    private void Start()
    {
        controller = GetComponent<XRController>();
    }

    /*private void Update()
    {
        CheckGrabInput();
    }

    private void CheckGrabInput()
    {
        // Check if the grab button is pressed
        if (controller.inputDevice.TryGetFeatureValue(CommonUsages.grip, out bool isGrabPressed) && isGrabPressed)
        {
            if (!isGrabbing)
            {
                // If not currently grabbing, try to pick up an object
                TryGrabObject();
            }
        }
        else
        {
            // If the grab button is not pressed, release the held object
            ReleaseObject();
        }
    }

    private void TryGrabObject()
    {
        RaycastHit hit;
        if (Physics.Raycast(controller.transform.position, controller.transform.forward, out hit))
        {
            InteractableObject interactable = hit.collider.GetComponent<InteractableObject>();
            if (interactable != null && !interactable.IsGrabbed)
            {
                interactable.Grab(controller.transform);
                currentHeldObject = interactable.gameObject;
                isGrabbing = true;
            }
        }
    }

    private void ReleaseObject()
    {
        if (currentHeldObject != null && isGrabbing)
        {
            InteractableObject interactable = currentHeldObject.GetComponent<InteractableObject>();
            if (interactable != null)
            {
                interactable.Release();
                currentHeldObject = null;
                isGrabbing = false;
            }
        }
    }*/
}