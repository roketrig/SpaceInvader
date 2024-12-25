using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObsticles : MonoBehaviour
{
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Wall"))
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(this.gameObject);
            DealDamage();
        }
    }

    private void DealDamage()
    {
        // Belli miktarda hasar atmak için kullanılacak
    }
}
