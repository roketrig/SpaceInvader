using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public Bullet bullet;
    public float LifeTime = 5f;

    private void Start()
    {
        Destroy(gameObject, LifeTime);
    }

    private void Update()
    {
        transform.Translate(Vector2.up * bullet.speed * Time.deltaTime);
    }
}
