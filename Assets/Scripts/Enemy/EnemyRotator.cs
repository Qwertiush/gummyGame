using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemyRotator : MonoBehaviour
{
    public AIPath aiPath;
    void Update()
    {
        if(aiPath.desiredVelocity.x >= 0.01f)
        {
            transform.Rotate(0f, 0f, -180f);
        }
        else transform.Rotate(0f, 0f, 0f);
    }
}
