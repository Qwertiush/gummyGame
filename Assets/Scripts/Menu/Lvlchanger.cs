using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lvlchanger : MonoBehaviour
{
    public string lvl;

    public void Load()
    {
        SceneManager.LoadScene("Menu");
    }
}
