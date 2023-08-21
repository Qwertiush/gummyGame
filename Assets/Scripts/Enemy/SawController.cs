using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawController : MonoBehaviour
{
    public GameObject losePanel;
    public float rSpeed;

    public float speed, distance;
    public Transform groundDdetection;

    public bool isMovingRight=false;


    private void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        RaycastHit2D hitInfo = Physics2D.Raycast(groundDdetection.position, Vector2.down, distance);

        if(hitInfo.collider == false)
        {
            if(isMovingRight==true)
            {
                transform.eulerAngles = new Vector3(0, -180f, 0);
                isMovingRight = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                isMovingRight = true;
            }
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Player")
        {
            losePanel.SetActive(true);
        }
    }
}
