using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundManager : MonoBehaviour
{
   




    public GameObject GameMenu; //panel for music and start
    public GameObject SoundMenu; // panel for audio settings
    public AudioSource gameMusic_01;

    private void Start()
    {
        AudioListener.volume = (float)volume;
    }

    public void GameMenuOn()
    {
        //  GameMenu.SetActive(true);
        gameMusic_01.Play();
    }

    public void GameMenuOff()
    {
        //    GameMenu.SetActive(false);
        gameMusic_01.Stop();
    }
    public void SoundMenuOn()
    {
        SoundMenu.SetActive(true);
        Debug.Log("On");
    }

    public void SoundMenuOff()
    {
        SoundMenu.SetActive(false);
        Debug.Log("Off");
    }

    static public double volume = 1;


    public void SoundVolumeUp()
    {
        volume = volume + 0.1;

        if (volume < 2)
            AudioListener.volume = AudioListener.volume + 0.1f;
        Debug.Log("Up");
    }

    public void SoundVolumeDown()
    {
        volume = volume - 0.1;

        if (volume > 0)
            AudioListener.volume = AudioListener.volume - 0.1f;
        Debug.Log("Down");
    }

    public void SoundVolumeOn()
    {
        AudioListener.volume = (float)volume;
    }

    public void SoundVolumeOff()
    {
        AudioListener.volume = 0;

    }

    public void SceneChange_01()
    {
        SceneManager.LoadScene("Scene_01");
    }

    public void SceneChange_02()
    {
        SceneManager.LoadScene("Scene_02");
    }

    public void Stop()
    {
        Time.timeScale = 0;
    }

    public void Resume()
    {
        Time.timeScale = 1;
    }


}

