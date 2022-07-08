using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform target;
    public float trailDistance = 5.0f;
    public float heightOffset = 4.0f;
    public float cameraDelay = 0.01f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 followPos = target.position - trailDistance * target.forward;
        
        followPos.y += heightOffset; 
        transform.position = Vector3.Lerp(followPos, transform.position, 0.99f);
        
        transform.LookAt(target.transform);
    }

    internal Vector3 ScreenPointToRay(Vector3 mousePosition)
    {
        throw new NotImplementedException();
    }
}
