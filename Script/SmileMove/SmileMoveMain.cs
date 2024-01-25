using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class SmileMoveMain : MonoBehaviour
{
    void Awake(){
        // スマイルボディにリジッドボディを設定
        _smileBody = smileBall.GetComponent<Rigidbody2D>();
        // アプリケーションのフレームレート最大値を制限
        Application.targetFrameRate = targetFrameRate;
        // フレームレートの経過時間の設定
        _deltaTime = 0.0f;

        rightWall = false;
        triggerWall = false;
        triggerFloor = false;
        InitializeParameters();
    }
    void Update(){
        if(!isStartGame) {return;}
        if(Input.GetKeyDown(KeyCode.Escape)){ selectSC.PressEscape();}
        if(DEBUG_RESSET_MODE||Input.GetKeyDown(KeyCode.R)){DEBUG_RESSET_MODE=false;ResetPosition(true);}
        AddTimer();
    }
    void FixedUpdate(){
        if(!isStartGame) {return;}
        SpeedCheck();
    }
    void OnGUI()
    {
        if (!isStartGame) {return;}
        // UI系
        GUI.skin.label.fontSize = 25;
        GUI.contentColor = Color.black;
        GUILayout.Label(
            "タイム: " + FormatTime(_time) +
            "\n" + shotCounter + "Shot" +
            "\nミス回数: " + deathCount
        ); // FPSを小数点以下2桁で表示
    }
}
