using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    public Transform bar;
    public float setSizeP;
    void Update()
    {
        bar.localScale = new Vector2(setSizeP*50, 5f);
    }
}
