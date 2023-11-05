using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class settings : MonoBehaviour
{
    public AudioMixer sound;
    public void Volumesetting(float volume) 
    {
      sound.SetFloat("volume", volume);  
        
    }
    
    public void Fullscreen(bool isfullscreen) 
    {
        Screen.fullScreen = isfullscreen;
    }
}
