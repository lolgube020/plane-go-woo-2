using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds; // det h�r �r en lista som ska ineh�lla ljudfiler fr�n sound scriptet - Marcus.

    // Start is called before the first frame update
    void Awake()
    {
        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();

            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
        }
    }

    public void Play(string name) //Denna funktion spelar upp ljudfiler - Marcus
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Play(); 
    }

}
