using System;
using UnityEngine;

public class FallSpawner : MonoBehaviour
{
    [SerializeField] private GameObject fallPrefab;
    [SerializeField] private RectTransform[] spawnPoints;

    [SerializeField] private RectTransform parentUI;

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

        RectTransform point = spawnPoints[randomIntex];

        GameObject obj = Instantiate(fallPrefab, parentUI);

        RectTransform rect = obj.GetComponent<RectTransform>();

        rect.anchoredPosition = point.anchoredPosition;
    }
}
