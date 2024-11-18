using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ObjectSpawner : MonoBehaviour
{
    public List<GameObject> Objects;
    
    private void Start()
    {
        StartCoroutine(SpawnObjects());
    }

    private IEnumerator SpawnObjects()
    {
        while (true)
        {
            int num = Random.Range(0, Objects.Count);
            Vector2 position = new Vector2(Random.Range(-6,6),7);
            Instantiate(Objects[num], position, Quaternion.identity);
            yield return new WaitForSeconds(Random.Range(0.8f, 3f));
        }
    }
}
