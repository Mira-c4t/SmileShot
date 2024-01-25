using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class AudioMain : MonoBehaviour
{
    public void Reset(){
        resetAudio();
    }
    public void GameBGM_Start(){
        gameBgm(true);
    }
    public void GameBGM_Stop(){
        gameBgm(false);
    }
    public void GameBGM_Pause(){
        gameBgmPause(true);
    }
    public void GameBGM_UnPause(){
        gameBgmPause(false);
    }
    public void GameBGM_Restart(){
        gameBgmRestart();
    }
    public void Gorogoro_Start(){
        gorogoro(true);
    }
    public void Gorogoro_Stop(){
        gorogoro(false);
    }
    public void PauseBGM_Start(){
        pauseBgm(true);
    }
    public void PauseBGM_Stop(){
        pauseBgm(false);
    }
    public void boundSound_Start(){
        boundSound();
    }
    public void tapSound_Start(){
        PlayTapSound(true);
    }
    public void tapSound_Stop(){
        PlayTapSound(false);
    }
    public void longSound_Start(){
        PlayLongSound(true);
    }
    public void longSound_Stop(){
        PlayLongSound(false);
    }
    public void deaSound(){
        deathSound();
    }
    public void downBGMPitch(){
        downPitch();
    }
    public void tapPitch(float pit){
        changePitch(AudioSources[2], pit);
    }
    public void longPitch(float pit){
        changePitch(AudioSources[7], pit);
    }
    public void clearSound_Start(){
        clearSound();
    }
    public void tap(){
        tapSound();
    }
    public void PressEscapeSound(){
        EscapeSound();
    }
    public void shot(){
        shotSound();
    }
}
