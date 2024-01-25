using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class StageMain : MonoBehaviour
{
    public void SelectStageButton_1()
    {
        AudioScript.tap();
        SelectStage(0);
    }
    public void SelectStageButton_2()
    {
        AudioScript.tap();
        SelectStage(1);
    }
    public void SelectStageButton_3()
    {
        AudioScript.tap();
        SelectStage(2);
    }
    public void SelectStageButton_4()
    {
        AudioScript.tap();
        SelectStage(3);
    }
    public void SelectStageButton_5()
    {
        AudioScript.tap();
        SelectStage(4);
    }
    public void ResumeButton(){
        AudioScript.tap();
        ResumeSelect();
    }
    public void BackMenuButton(){
        AudioScript.tap();
        BackMenuSelect();
    }
    public void RestartButton(){
        AudioScript.tap();
        RestartSelect();
    }
    public void PushBackMenuButton_onGoal(){
        BackMenuByClearMenu();
    }

    public void PushChangeGameMode_1(){
        _smileBallSC.gameMode = !toggleButtons[0].isOn;
        SynchronizeGamemode();
    }
    public void PushChangeGameMode_2(){
        _smileBallSC.gameMode = !toggleButtons[1].isOn;
        SynchronizeGamemode();
    }
}
