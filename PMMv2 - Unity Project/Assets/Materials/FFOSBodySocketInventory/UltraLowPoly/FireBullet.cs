using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
[RequireComponent(typeof(AudioSource))]
public class FireBullet : MonoBehaviour
{
    public float speed = 50f;
    public float Ammo = 0f;
    public GameObject bulletObj;
    public Transform frontOfGun;
    private Animator gunAnim;
    public GameObject muzzleFlash;

    private GameObject gm;

    private void Start()
    {
        gunAnim = GetComponent<Animator>();
        gm = GameObject.FindGameObjectWithTag("GameManager");
    }

    private void Update()
    {
        Ammo = gm.GetComponent<GameManager>().getAmmo();
    }

    public static event Action GunFired;
    public void Fire()
    {
        if (Ammo > 0)
        {
            GetComponent<AudioSource>().Play();
            gunAnim.SetBool("Shoot", true);
            GameObject spawnedBullet = Instantiate(bulletObj, frontOfGun.position, frontOfGun.rotation);
            spawnedBullet.GetComponent<Rigidbody>().velocity = speed * frontOfGun.forward;
            GameObject spawnedFlash = Instantiate(muzzleFlash, frontOfGun.position, frontOfGun.rotation);
            Destroy(spawnedFlash, 1f);
            Destroy(spawnedBullet, 7f);            
           // GunFired?.Invoke();
            gm.GetComponent<GameManager>().shootAmmo();
            gunAnim.SetBool("Shoot", false);
        }
    }

   


}
