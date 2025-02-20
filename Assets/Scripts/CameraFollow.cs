using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; 
    public float smoothSpeed = 5f; 
    public Vector3 offset; 
    void LateUpdate()
    {
        if (target == null)
            return;

        
        Vector3 targetPosition = target.position + offset;

        
        transform.position = Vector3.Lerp(transform.position, targetPosition, smoothSpeed * Time.deltaTime);
    }
}

