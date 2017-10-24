using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionControllButton : MonoBehaviour
{
    public Slider s_VolumeSlider;
    public AudioSource volume;
    

    private void Start()
    {
        s_VolumeSlider.value = Singletons.musicVolume;
    }

    public void ResetVolumeValue()
    {
        Singletons.musicVolume = s_VolumeSlider.value;
        volume.volume = Singletons.musicVolume;
    }    
}
