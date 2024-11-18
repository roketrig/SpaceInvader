using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{
    public float scrollSpeed = 0.5f; 
    private Material backgroundMaterial;
    private Vector2 offset;

    private void Start()
    {
        backgroundMaterial = GetComponent<Renderer>().material;
        offset = new Vector2(scrollSpeed, 0); 
    }

    private void Update()
    {
        backgroundMaterial.mainTextureOffset += offset * Time.deltaTime;
    }
}