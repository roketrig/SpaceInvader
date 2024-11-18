using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public Bullet bullet;
    public Transform ShootPos;
    private float nextFireTime;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Time.time >= nextFireTime)
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        
        Instantiate(bullet.bulletPrefab, ShootPos.position,ShootPos.rotation);

        nextFireTime = Time.time + bullet.fireRate;
    }
}
