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

    private ObjectPooler objectPooler;
    private const string PrefabTag = "Pipe";
    private float timer = 0f;
    
    void Start()
    {
        objectPooler = ObjectPooler.Instance;
        GameObject newPipe = objectPooler.SpawnFromPool(PrefabTag, GetPipePosition(), Quaternion.identity);
    }
    
    void Update()
    {
        if (timer > spawnInterval)
        {
            GameObject newPipe = objectPooler.SpawnFromPool(PrefabTag, GetPipePosition(), Quaternion.identity);
            Destroy(newPipe, 15);
            timer = 0;
        }

        timer += Time.deltaTime;
    }

    private Vector3 GetPipePosition()
    {
        return transform.position + new Vector3(0, Random.Range(minHeight, maxHeight), 0);
    }
}
