using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public partial class StageMain
{
    [Header("スマイルムーブスクリプト")]
    [SerializeField]
    private SmileMoveMain _smileBallSC;

    [Header("ゲームモード変更のトグルボタンオブジェクト")]
    [SerializeField]
    private Toggle[] toggleButtons;

    [Header("オーディオ管理スクリプト")]
    [SerializeField]
    private AudioMain AudioScript;

    [Header("ステージ番号")]
    [SerializeField]
    private int _stageInt;

    [Header("難易度選択パネル")]
    [SerializeField]
    private GameObject _SelectPanel;

    [Header("ポーズ画面パネル")]
    [SerializeField]
    private GameObject _PausePanel;

    [Header("クリア画面パネル")]
    [SerializeField]
    private GameObject _ClearPanel;

    [Header("クリアオブジェクト(リスト)")]
    [Header("0 : クリア時間")]
    [Header("1 : ショット回数")]
    [Header("2 : 死亡回数")]
    [SerializeField]
    public Text[] _textObjects;

    [Header("ステージオブジェクト(リスト)")]
    [SerializeField]
    public GameObject[] _stageObjects;

    [Header("トリガーオブジェクト(リスト)")]
    [SerializeField]
    public GameObject[] _triggerObjects;

    [SerializeField]
    private bool isPauseGame = false;
}
