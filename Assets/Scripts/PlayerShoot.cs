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
    public float shootPower = 10000f;
    public InputActionReference trigger;
    //[SerializeField]
    //private AudioSource myAudioSource;
    void Start()
    {
        trigger.action.performed += Shoot;
    }

    void Shoot(InputAction.CallbackContext obj){

        GameObject newArrow = Instantiate(ArrowTemplate, transform.position, crossbow.transform.rotation * Quaternion.Euler(0f,0f,180f));
        newArrow.GetComponent<Rigidbody>().AddForce(transform.forward * shootPower);

    }//crossbow.transform.rotation * Quaternion.Euler(32f,82f,0f)
   
}
