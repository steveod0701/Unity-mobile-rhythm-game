using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MusicPlayer : MonoBehaviour
{
    
    public AudioSource music;

    public void PauseMusic()
    {
        music.Pause();
    }
    
    public void UnPauseMusic()
    {
        music.UnPause();
    }

    private void OnTriggerEnter(Collider other)
    {
        
        music.Play();
    }
}
