using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GroundDetection groundDetection;

    Rigidbody2D rig;
    public float speed,jumpForce;

    public Transform pointer;
    public Vector2 lookDirection;
    float lookAngle;
    public GameObject buLLet;
    public float shootPower;


    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        lookDirection = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        lookAngle = Mathf.Atan2(lookDirection.x, lookDirection.y) * Mathf.Rad2Deg;

        if (Input.GetKeyDown(KeyCode.P))
            Fire();


        if(Input.GetKey(KeyCode.D))
        {
            rig.AddForce(Vector2.right*speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rig.AddForce(Vector2.left*speed);
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(groundDetection.isGrounded==true)
            rig.AddForce(Vector2.up*jumpForce);
        }
    }
    void Fire()
    {
        GameObject bullet = Instantiate(buLLet, pointer.position, pointer.rotation);
        bullet.GetComponent<Rigidbody2D>().velocity = pointer.up * shootPower;
    }

}
