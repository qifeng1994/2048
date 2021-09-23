using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuPanel : MonoBehaviour
{
    public StartPanel startPanel;
    public OptionPanel optionPanel;
    public void OnStartButtonClicked()
    {
        gameObject.SetActive(false);
        startPanel.gameObject.SetActive(true);
    }

    public void OnOptionButtonClicked()
    {
        gameObject.SetActive(false);
        optionPanel.gameObject.SetActive(true);
    }

    public void OnExitButtonClicked()
    {
        Application.Quit();
    }
}
