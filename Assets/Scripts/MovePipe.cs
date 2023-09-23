using UnityEngine;

namespace FlappyBird
{
    public class MovePipe : MonoBehaviour
    {
        [SerializeField] private float speed;
    
        void Update()
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
    }

}

