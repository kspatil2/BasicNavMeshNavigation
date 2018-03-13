using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NodeBasedNavigationBehaviourScript : MonoBehaviour {

    public Transform[] target;
    NavMeshAgent agent;
    public int current_node;
    public float distance_to_node;
    // Use this for initialization
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        current_node = 0;
    }

    // Update is called once per frame
    void Update()
    {
        float current_distance = (transform.position - target[current_node].position).magnitude;
        if ( current_distance <= distance_to_node)
        {
            current_node = (current_node + 1) % target.Length;
        }

        agent.SetDestination(target[current_node].position);

    }
}
