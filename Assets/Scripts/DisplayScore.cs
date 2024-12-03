using UnityEngine;
using TMPro;

public class DisplayScore : MonoBehaviour
{
    public TextMeshPro scoreText;

    void Start()
    {
        int finalScore = Score.score; 

        scoreText.text = "Final Score: " + finalScore;

        // Optional: Reset score after displaying
        Score.ResetScore();
    }
}