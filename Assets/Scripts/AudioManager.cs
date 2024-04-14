using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;
    public AudioSource backgroundMusic;
    public AudioSource backgroundAmbience;
    public AudioSource pageTurn;
    public AudioSource summonVwoop; 

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    public void PlayBackMusic()
    {
        backgroundMusic.pitch = 0.8f;
        backgroundMusic.panStereo = -0.7f;
        backgroundMusic.volume = 0.1f;
        backgroundAmbience.Play();
    }

    public void PlayFrontMusic()
    {
        backgroundMusic.pitch = 1f;
        backgroundMusic.panStereo = 0f;
        backgroundMusic.volume = 0.25f;
        backgroundAmbience.Stop();
    }

}
