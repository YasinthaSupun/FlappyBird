using UnityEngine;

namespace FlappyBird
{
    public class PipeSpawner : MonoBehaviour
    {
        [SerializeField] private float spawnInterval;
        [SerializeField] private float minHeight;
        [SerializeField] private float maxHeight;

        private ObjectPooler objectPooler;
        private const string PrefabTag = "Pipe";

        void Start()
        {
            objectPooler = ObjectPooler.Instance;
            InvokeRepeating(nameof(SpawnPipe), spawnInterval, spawnInterval);
        }
    
        private void SpawnPipe()
        {
            Vector3 position = transform.position + new Vector3(0, Random.Range(minHeight, maxHeight), 0);
            objectPooler.SpawnFromPool(PrefabTag, position, Quaternion.identity);
        }
    }

}

