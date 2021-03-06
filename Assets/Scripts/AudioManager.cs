using UnityEngine.Audio;
using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;
    
    // Start is called before the first frame update
    void Awake()
    {
        foreach (Sound s in sounds)
        {
                s.source = gameObject.AddComponent<AudioSource>();
                s.source.clip = s.clip;
                s.source.loop=s.loop;
                s.source.volume = s.volume;
                s.source.pitch = s.pitch;
                s.source.outputAudioMixerGroup=s.outputAudioMixerGroup;
        }
    }

    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Play();
    }    
    
    public void Stop(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Stop();
    }
}
