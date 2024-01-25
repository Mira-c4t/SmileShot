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
        gaugeOutsideObject.SetActive(true);
        smileBall.SetActive(true);
        isStartGame = true;
    }
    public void gameStop_onsmileScript(){
        gaugeOutsideObject.SetActive(false);
        smileBall.SetActive(false);
        isStartGame = false;
    }
}
