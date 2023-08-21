using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikesScript : MonoBehaviour
{
    public GameObject losePanel;
    public bool isDead=false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Player")
        {
            Debug.Log("death");
            isDead = true;
        }
    }
    private void Update()
    {
        if(isDead)
        {
            losePanel.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
