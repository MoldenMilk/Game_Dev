using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Guard : MonoBehaviour
{
    public Transform[] waypoints;
    public bool loopway = true;
    private NavMeshAgent agent;


    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        StartCoroutine("Patrol");
    }

    IEnumerator Patrol()
    {
        agent.SetDestination(waypoints[0].position);
        int wp = 0;

        while(true)
        {
            if(Vector3.Distance(waypoints[wp].position, transform.position)<2)
            {
                // Debug.Log(""+Vector3.Distance(waypoints[wp].position, transform.position));
                if(wp == waypoints.Length-1)
                {
                    if(loopway)
                    {
                        wp = 0;
                        agent.SetDestination(waypoints[0].position);
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    wp++;
                    agent.SetDestination(waypoints[wp].position);
                }
            }
            yield return new WaitForSeconds(.5f);
        }
        yield return null;
    }
}
