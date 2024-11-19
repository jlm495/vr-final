using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField]
    private GameObject ArrowTemplate;
    [SerializeField]
    private GameObject crossbow;
    public float shootPower = 500f;
    public InputActionReference trigger;
    //[SerializeField]
    //private AudioSource myAudioSource;
    void Start()
    {
        trigger.action.performed += Shoot;
    }

    void Shoot(InputAction.CallbackContext obj){

        //myAudioSource.Play();
        GameObject newArrow = Instantiate(ArrowTemplate, transform.position, crossbow.transform.rotation * Quaternion.Euler(32f,82f,0f));
        newArrow.GetComponent<Rigidbody>().AddForce(transform.forward * shootPower);
        //Quaternion.Euler(90.0f,100.0f,135.0f)

    }
   
}
