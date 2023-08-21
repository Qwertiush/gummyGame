using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemysHealth : MonoBehaviour
{
    public float health, damage;
    public HealthBar healthBar;
    public GameObject explosion;
    public Transform explosionPoint;
    public AudioSource soundExp;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Bullet")
        {
            health -= damage;
            healthBar.setSizeP = health/100;
        }
    }
    private void Update()
    {
        if(health<=0)
        {
            GameObject exp = Instantiate(explosion, explosionPoint.position, explosionPoint.rotation);
            soundExp.Play();
            Destroy(this.gameObject);
        }
    }
}
