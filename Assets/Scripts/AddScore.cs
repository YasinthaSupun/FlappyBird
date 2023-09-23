using UnityEngine;

namespace FlappyBird
{
    public class AddScore : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            Score.score ++;
        }
    }

}

