using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundDetection : MonoBehaviour
{
    public bool isGrounded = false;
    public AudioClip hitSound;
    public Transform playerPos;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag=="Ground")
        {
            isGrounded = true;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ground")
        {
            AudioSource.PlayClipAtPoint(hitSound, playerPos.position);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Ground")
        {
            isGrounded = false;
        }
    }

}
