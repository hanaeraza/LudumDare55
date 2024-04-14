using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentScene : ScriptableObject
{
    [SerializeField]
    public static string currentScene = "customersTests";
    [SerializeField]
    public static AudioSource backgroundMusic;
    [SerializeField]
    public static AudioSource backgroundAmbience; 
        
}
