using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class obDestination : MonoBehaviour
{
    NavMeshAgent agent;
    public Transform Target; //hedef

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

   
    void Update()
    {
        agent.destination = Target.position;
    }
}
