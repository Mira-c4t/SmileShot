using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public partial class StageMain : MonoBehaviour
{
    private void ResetStage()
    {
        foreach(GameObject obj in _stageObjects){ obj.SetActive(false); }
        foreach(GameObject obj in _triggerObjects){ obj.SetActive(false); }
    }
    private void ScoreSet(){
        _textObjects[0].text = _smileBallSC.FormatTime(_smileBallSC._time).ToString();
        _textObjects[1].text = _smileBallSC.shotCounter.ToString();
        _textObjects[2].text = _smileBallSC.deathCount.ToString();
    }
    private void BackMenuSelect(){
        StopGame();
        AudioScript.PauseBGM_Stop();
        _PausePanel.SetActive(false);
        _ClearPanel.SetActive(false);
        _SelectPanel.SetActive(true);
        ResetStage();
        _smileBallSC.InitializeParameters();
        Time.timeScale = 1;
        isPauseGame = false;
        _smileBallSC.isPauseGame = false;
    }
    private void ClearMenu(){
        StopGame();
        ScoreSet();
        AudioScript.PauseBGM_Stop();
        _ClearPanel.SetActive(true);
        ResetStage();
    }
    private void BackMenuByClearMenu(){
        BackMenuSelect();
    }
    private void ResumeSelect(){
        ResumeGame();
    }
    private void RestartSelect(){
        AudioScript.GameBGM_Restart();
        AudioScript.Gorogoro_Stop();
        ResumeGame();
        _smileBallSC.ResetPosition(true);
    }
    private void StartGame(){
        AudioScript.GameBGM_Start();
        _smileBallSC.gameStart_onsmileScript();
    }
    private void StopGame(){
        AudioScript.GameBGM_Stop();
        AudioScript.Gorogoro_Stop();
        _smileBallSC.gameStop_onsmileScript();
    }
    private void PauseGame()
    {
        _PausePanel.SetActive(true);
        AudioScript.PauseBGM_Start();
        AudioScript.Gorogoro_Stop();
        AudioScript.GameBGM_Pause();
        Time.timeScale = 0;
        isPauseGame = true;
        _smileBallSC.isPauseGame = true;
    }
    private void ResumeGame()
    {
        _PausePanel.SetActive(false);
        AudioScript.PauseBGM_Stop();
        AudioScript.GameBGM_UnPause();
        Time.timeScale = 1;
        isPauseGame = false;
        _smileBallSC.isPauseGame = false;
    }

    private void SynchronizeGamemode()
    {
        foreach(Toggle obj in toggleButtons)
        {
            obj.isOn = !_smileBallSC.gameMode;
        }
    }
}
