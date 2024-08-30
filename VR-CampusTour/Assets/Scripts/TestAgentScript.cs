using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.AI;

public class TestAgentScript : MonoBehaviour
{
    //목표지점 좌표
    public Transform target;

    //캐릭터의 navmeshagent 참조
    NavMeshAgent agent;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    private void Update()
    {
        agent.SetDestination(target.position);
    }
}
