using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartPanel : MonoBehaviour
{
    public MainMenuPanel mainMenuPanel;
    public void OnModeButtonClicked(int count)
    {
        PlayerPrefs.SetInt(GameConst.gameModeCount, count);
        Debug.Log(count);
        //未完成：按照数字加载对应的格子

        SceneManager.LoadSceneAsync(1);
    }

    public void OnReturnButtonClicked()
    {
        gameObject.SetActive(false);
        mainMenuPanel.gameObject.SetActive(true);
    }
}
