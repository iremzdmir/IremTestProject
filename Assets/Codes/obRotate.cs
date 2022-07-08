using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obRotate : MonoBehaviour
{
    public float donmeHizi = 2.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rot = transform.eulerAngles;
        transform.rotation = Quaternion.Euler(rot.x, rot.y, rot.z + Time.deltaTime * donmeHizi);
    }
}
