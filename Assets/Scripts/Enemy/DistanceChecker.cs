using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class DistanceChecker : MonoBehaviour
{
    public GameObject playerPos;
    public float distance;
    public float range;
    private void Start()
    {
        playerPos = GameObject.FindWithTag("Player");
    }

    void Update()
    {
        distance = Vector2.Distance(transform.position, playerPos.transform.position);

        if(distance<=range)
        {
            GetComponent<AIPath>().enabled = true;
        }
    }
}
