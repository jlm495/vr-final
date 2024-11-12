using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    private float timer = 300f;
    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
              
        if(timer < 0){
            // reset scene
            SceneManager.LoadScene("Scenes/StartScene");

        }
    }
}
