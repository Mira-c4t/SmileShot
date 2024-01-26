using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class SmileMoveMain : MonoBehaviour
{
    public void ResetPosition(bool isFirst = false){
        if(isFirst){InitializeParameters();}
        _smileBody.velocity = Vector2.zero;
        _smileBody.angularVelocity = 0.0f;
        smileBall.transform.position = _ResetPos;
        ChangeImageStrong();
    }
    public void InitializeParameters()
    {
        // ショット数の初期化
        shotCounter = 0;
        // タイマーのリセット
        _time = 0f;
        // 死亡回数のリセット
        deathCount = 0;

        _gorogoroCalled = false;
        soundSC.Reset();
    }
    public void GoalYeah(){
        gameStop_onsmileScript();
        selectSC.GoalLetsGo();
    }
    public void gameStart_onsmileScript(){
        gaugeImage.SetActive(true);
        pauseButton.SetActive(true);
        SubCamera.SetActive(true);
        smileBall.SetActive(true);
        isStartGame = true;
    }
    public void gameStop_onsmileScript(){
        gaugeImage.SetActive(false);
        pauseButton.SetActive(false);
        SubCamera.SetActive(false);
        smileBall.SetActive(false);
        isStartGame = false;
    }
}
