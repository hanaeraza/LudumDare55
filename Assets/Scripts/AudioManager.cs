using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource backgroundAudio;
    public AudioSource backgroundAmbient; 
    public AudioSource SFX; 

    public AudioClip backgroundMusic;
    public AudioClip doorOpen;
    public AudioClip summon;
    public AudioClip pageTurn;
    public AudioClip doorChime; 

   
    public void playSFX(AudioClip clip)
    {
        SFX.clip = clip;
        SFX.Play(); 
    }

    public void playFrontroomMusic()
    {
        backgroundAudio.pitch = 1f;
        backgroundAmbient.Stop(); 
    }

    public void playBackroomMusic()
    {
        backgroundAudio.pitch = 0.8f;
        backgroundAmbient.Play(); 
    }

}
