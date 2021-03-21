using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy1 : MonoBehaviour
{
    private NavMeshAgent agent;
    public float ScanRarius = 40f;
    Transform Target;
    private Animator animator;



    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = this.GetComponent<Animator>();
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

    private void OnTriggerEnter(Collider other) 
    {
        if(other.tag == "Player")
        {
            animator.SetInteger("state", 1);
            Invoke("Run", 1.46f);
        }
    }

    private void Run()
    {
        animator.SetInteger("state", 0);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, ScanRarius);
    }
}
