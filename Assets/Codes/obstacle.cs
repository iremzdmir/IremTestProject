using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle : MonoBehaviour
{
    public Rigidbody rb;
    public float speed=3.0f;
    public float forceSpeed;
    public bool timer;

    void Start()
    {
        forceSpeed = speed;
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = Vector3.forward * forceSpeed;

        if (timer)
        {
           
            if (forceSpeed > 0)
            {
                forceSpeed = -speed;
                timer = false;
            }else if(forceSpeed < 0)
            {
                forceSpeed = speed;
                timer = false;
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "stop")
        {
            timer = true;
        }
    }
}
