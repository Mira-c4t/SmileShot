using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class AudioMain : MonoBehaviour
{
    void Start()
    {
        int i = 0;
        foreach (AudioClip sound in Sounds)
        {
            AudioSource newAudioSource = SoundObj.AddComponent<AudioSource>();
            newAudioSource.clip = sound;
            newAudioSource.playOnAwake = false;
            newAudioSource.volume = 0.2f;
            if(i == 0 || i == 1 || i == 2 || i == 7)
            {
                newAudioSource.loop = true;
            }
            if(i == 10){newAudioSource.volume = 1f;}
            AudioSources.Add(newAudioSource);
            i++;
        }
    }
}
