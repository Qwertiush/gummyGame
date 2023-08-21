using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsPlayerFallen : MonoBehaviour
{
    public Transform playerPos;
    public Vector2 deathPosition;
    public GameObject losePanel;
    void Update()
    {
        if(playerPos.position.y<=deathPosition.y)
        {
            losePanel.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
