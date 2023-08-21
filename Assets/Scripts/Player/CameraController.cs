using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform playerPosition;
    public Vector3 offset;
    void Update()
    {
        transform.position = playerPosition.position + offset;
    }
}
