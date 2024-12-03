using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    [SerializeField]
    private int lives = 5;

    [SerializeField]
    private int points = 5;


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("arrow"))
        {
            lives--;

            if (lives <= 0) 
            {
                Destroy(gameObject);
                Score.AddScore(points);
            }
            
            Destroy(collision.gameObject);
        }
    }
}