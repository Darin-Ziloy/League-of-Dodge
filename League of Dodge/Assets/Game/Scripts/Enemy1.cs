using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy1 : MonoBehaviour
{
    private NavMeshAgent agent;
    public float ScanRarius = 40f;
    Transform Target;



    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        Target = Manager.manager.EnemyTarget.transform;
    }


    void Update()
    {
        float Distance = Vector3.Distance(Target.position, transform.position);
        if (Distance <= ScanRarius)
        {
            agent.SetDestination(Target.position);
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, ScanRarius);
    }
}
