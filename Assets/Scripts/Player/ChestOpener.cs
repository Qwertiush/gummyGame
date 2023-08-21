using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestOpener : MonoBehaviour
{
    public int haveKey=0;
    public GameObject winPanel;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Player")
        {
            if (haveKey>=5)
            {
                winPanel.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }


}
