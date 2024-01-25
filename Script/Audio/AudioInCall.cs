using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class AudioMain : MonoBehaviour
{
    private void resetAudio(){
        foreach (AudioSource source in AudioSources){
            changePitch(source, 1f);
        }
    }
    private void PlayTapSound(bool isStart){
        if(isStart){AudioSources[2].Play();}
        else{AudioSources[2].Stop();}
    }
    private void PlayLongSound(bool isStart){
        if(isStart){AudioSources[7].Play();}
        else{AudioSources[7].Stop();}
    }
    private void gameBgm(bool isStart){
        if(isStart){AudioSources[0].Play();}
        else{AudioSources[0].Stop();}
    }
    private void gameBgmPause(bool isntPause){
        if(isntPause){AudioSources[0].Pause();}
        else{AudioSources[0].UnPause();}
    }
    private void gameBgmRestart(){
        AudioSources[0].time = 0f;
    }
    private void gorogoro(bool isPlay){
        if(isPlay){AudioSources[1].Play();}
        else{AudioSources[1].Stop();}
    }
    private void pauseBgm(bool isPause){
        if(isPause){AudioSources[3].Play();}
        else{AudioSources[3].Stop();}
    }
    private void deathSound(){
        AudioSources[9].PlayOneShot(Sounds[9]);
    }
    private void boundSound(){
        AudioSources[4].PlayOneShot(Sounds[4]);
    }

    private void tapSound(){
        AudioSources[10].PlayOneShot(Sounds[10]);
    }

    private void EscapeSound(){
        AudioSources[11].PlayOneShot(Sounds[11]);
    }

    private void shotSound(){
        AudioSources[12].Play();
    }
    private void clearSound(){
        var trueOrFalse = Random.value > 0.5f;
        if(trueOrFalse){AudioSources[5].PlayOneShot(Sounds[5]);}
        else{AudioSources[6].PlayOneShot(Sounds[6]);}
        AudioSources[8].PlayOneShot(Sounds[8]);
    }
    private void downPitch(){
        foreach(AudioSource source in AudioSources)
        {
            changePitch(source, source.pitch - 0.1f);
        }
    }
    private void changePitch(AudioSource source, float pitFloat){
        source.pitch = pitFloat;
    }
}
