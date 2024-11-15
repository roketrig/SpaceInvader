using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BulletData", menuName = "ScriptableObjects/BulletData", order = 1)]
public class Bullet : ScriptableObject
{
    public GameObject bulletPrefab;
    public float damage;
    public float speed;
    public float fireRate;
}
