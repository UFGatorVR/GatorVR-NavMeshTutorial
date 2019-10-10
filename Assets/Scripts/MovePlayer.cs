using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MovePlayer : MonoBehaviour
{
    private RaycastHit hit;
    public NavMeshAgent agent;

    // Start is called before the first frame update.
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame.
    void Update()
    {
        // If user clicks on screen.
        if (Input.GetMouseButtonDown(0))
        {
            // Send raycast from screen to mouse position.
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray.origin, ray.direction, out hit))
            {
                agent.SetDestination(hit.point);
            }
        }
    }
}
