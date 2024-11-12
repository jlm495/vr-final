using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonRiding : MonoBehaviour
{
    public Transform movingObject; // Reference to the moving object (e.g. dragon)
    private Vector3 localPosition;
    private Quaternion localRotation;

    private void Start()
    {
        // Store the initial local position and rotation of the player relative to the moving object
        localPosition = transform.localPosition;
        localRotation = transform.localRotation;
    }

    private void LateUpdate()
    {
        // Update the player's position and rotation to match the moving object
        transform.position = movingObject.position + movingObject.TransformVector(localPosition);
        transform.rotation = movingObject.rotation * localRotation;
    }
}
