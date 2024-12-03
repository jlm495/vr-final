using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class ResetGame : MonoBehaviour
{
    public InputActionReference paddleLeft;

    void Start()
    {

        paddleLeft.action.performed += Reset;
        
    }

    void Reset(InputAction.CallbackContext obj){

        SceneManager.LoadScene("Scenes/StartScene");
        Score.ResetScore();
    }
}
