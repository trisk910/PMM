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

    private void Start()
    {
        gunAnim = GetComponent<Animator>();
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
            Destroy(spawnedBullet, 5f);
            gunAnim.SetBool("Shoot", false);
            GunFired?.Invoke();
        }
    }

    public void AddOneBullet()
    {
        Ammo++;
    }


}
