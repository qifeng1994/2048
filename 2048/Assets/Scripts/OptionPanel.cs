using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionPanel : MonoBehaviour
{
    public MainMenuPanel mainMenuPanel;
    
    public void OnReturnButtonClicked()
    {
        gameObject.SetActive(false);
        mainMenuPanel.gameObject.SetActive(true);
    }

    public void MusicSlider(float f)
    {
        PlayerPrefs.SetFloat(GameConst.musicValue, f);
        //
        Debug.Log(f);
    }

    public void EffectSlider(float f)
    {
        PlayerPrefs.SetFloat(GameConst.effectValue, f);
        //
        Debug.Log(f);
    }
}
