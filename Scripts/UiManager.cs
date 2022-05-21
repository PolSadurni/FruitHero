using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;

public class UiManager : MonoBehaviour
{

    public GameObject optionsPanel;
    public Text texto1;
    public Text texto2;
    public AudioSource clip;

    public void OptionsPanel()
    {
        texto1.gameObject.SetActive(false);
        texto2.gameObject.SetActive(false);
        Time.timeScale = 0;
        optionsPanel.SetActive(true);
    }

    public void Return()
    {
        texto1.gameObject.SetActive(true);
        texto2.gameObject.SetActive(true);
        Time.timeScale = 1;
        optionsPanel.SetActive(false);
    }

    public void DisableAudio()
    {
        clip.enabled = false;
    }

    public void GoMainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
