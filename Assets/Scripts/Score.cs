using UnityEngine;
using TMPro;

namespace FlappyBird
{
    public class Score : MonoBehaviour
    {
        public static int score = 0;
    
        void Start()
        {
            score = 0;
        }
    
        void Update()
        {
            GetComponent<TMP_Text>().text = score.ToString();
        }
    }

}

