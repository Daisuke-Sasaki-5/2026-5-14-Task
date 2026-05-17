using System;
using UnityEngine;

public class FallSpawner : MonoBehaviour
{
    [SerializeField] private GameObject fallPrefab;
    [SerializeField] private Transform[] spawnPoints;

    [SerializeField] private float spawnInterval = 1.0f;
    private float timer;

    private void Update()
    {
        timer += Time.deltaTime;

        if( timer >= spawnInterval )
        {
            Spawn();

            timer = 0;
        }
    }

    private void Spawn()
    {
        int randomIntex = UnityEngine.Random.Range(0, spawnPoints.Length);
        
        Instantiate(fallPrefab,spawnPoints[randomIntex].position,Quaternion.identity);
    }
}
