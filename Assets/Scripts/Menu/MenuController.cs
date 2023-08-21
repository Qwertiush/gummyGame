using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    public GameObject optionsPanel;
    public bool isOptionPOpened=false;
    public GameObject tutorialPanel;
    public bool isTutorialPOpened = false;

    public void OpenOptionsPanel()
    {
        optionsPanel.SetActive(true);
        isOptionPOpened = true;
    }
    public void OpenTutorialPanel()
    {
        tutorialPanel.SetActive(true);
        isTutorialPOpened = true;
    }


    void Update()
    {
        if (isOptionPOpened == true)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                isOptionPOpened = false;
                optionsPanel.SetActive(false);
            }
        }
        if (isTutorialPOpened == true)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                isTutorialPOpened = false;
                tutorialPanel.SetActive(false);
            }
        }
    }
}
