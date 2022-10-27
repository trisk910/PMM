using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RayCast : MonoBehaviour
{
    [SerializeField] private int raylength = 5;
    [SerializeField] private LayerMask LayerMaskInteract;
    [SerializeField] private string excludeLayerName = null;

    private doorController raycastedObj;

    [SerializeField] private KeyCode InterActKey = KeyCode.E; /// AIXO S'HAURÁ DE CAMBIAR QUAN S'UTILITZI EL GAMEPAD
    /// </summary>
    [SerializeField] private Image crosshair = null;
    private bool isCrossHairActive;
    private bool doOnce;
    private bool canOpen = true;

    private const string interactableTag = "InteractiveObject";

    private void Start()
    {
        crosshair.enabled = false;
    }
    // Update is called once per frame
    private void Update()
    {
        RaycastHit hit;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        int mask = 1 << LayerMask.NameToLayer(excludeLayerName) | LayerMaskInteract.value;

        if (Physics.Raycast(transform.position, fwd, out hit, raylength, mask))
        {
            if (hit.collider.CompareTag(interactableTag))
            {
                if (!doOnce)
                {
                    raycastedObj = hit.collider.gameObject.GetComponent<doorController>();
                    CrosshairChange(true);
                }
                isCrossHairActive = true;
                doOnce = true;

                if(canOpen)
                {
                    if (Input.GetKeyDown(InterActKey))
                    {
                        raycastedObj.PlayAnimation();
                        StartCoroutine(doorDelay(1.5f));
                        canOpen = false;
                    }
                }
               
            }
        }
        else
        {
            if (isCrossHairActive)
            {
                CrosshairChange(false);
                doOnce = false;
            }
        }
    }
    void CrosshairChange(bool on)
    {
        if (on && !doOnce)
            crosshair.enabled = true;
        else
        {
            crosshair.enabled = false;
            isCrossHairActive = false;
        }
    }
    IEnumerator doorDelay(float delayTime)
    {
        yield return new WaitForSeconds(delayTime);        
        canOpen = true ;
    }
}
