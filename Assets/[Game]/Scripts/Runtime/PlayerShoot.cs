using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public Bullet bullet;
    public Transform ShootPos;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("SpaceBasıldı");
            Instantiate(bullet.bulletPrefab, ShootPos.position,ShootPos.rotation);
        }
    }
}
