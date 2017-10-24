using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InGameOptionController : MonoBehaviour
{
    public GameObject optionPanel;

    private void Start()
    {
        optionPanel.SetActive(false);
    }

    public void PauseOn()
    {
        optionPanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void PauseOff()
    {
        optionPanel.SetActive(false);
        Time.timeScale = 1f;
    }

    public void GameSceneQuit()
    {
        SceneManager.LoadScene("Main");
        Time.timeScale = 1f;
    }

    public void GameRestart()
    {
        SceneManager.LoadScene("Level1");
        Time.timeScale = 1f;
    }
}
