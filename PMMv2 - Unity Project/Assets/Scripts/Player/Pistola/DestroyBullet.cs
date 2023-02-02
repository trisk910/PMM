using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullet : MonoBehaviour
{
    public void DestroyBulletOnGrab()
    {
        Destroy(this.gameObject);
    }
}
