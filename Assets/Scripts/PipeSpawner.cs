using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private float spawnInterval;
    [SerializeField] private GameObject pipePrefab;
    [SerializeField] private float minHeight;
    [SerializeField] private float maxHeight;

    private float timer = 0f;
    
    void Start()
    {
        GameObject newPipe = Instantiate(pipePrefab);
        newPipe.transform.position = transform.position + new Vector3(0, Random.Range(minHeight, maxHeight), 0);
    }
    
    void Update()
    {
        if (timer > spawnInterval)
        {
            GameObject newPipe = Instantiate(pipePrefab);
            newPipe.transform.position = transform.position + new Vector3(0, Random.Range(minHeight, maxHeight), 0);
            Destroy(newPipe, 15);
            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
