using UnityEngine;

namespace FlappyBird
{
    public class FlyBird : MonoBehaviour
    {
        [SerializeField] private float velocity = 1;
        [SerializeField] private GameManager gameManager;
        private Rigidbody2D rb;
    
        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
        }
    
        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                rb.velocity = Vector2.up * velocity;
            }
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            gameManager.GameOver();
        }
    }

}

