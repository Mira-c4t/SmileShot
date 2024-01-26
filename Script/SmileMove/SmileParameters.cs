using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public partial class SmileMoveMain : MonoBehaviour
{
    [Header("デバッグ用")]
    [SerializeField]
    bool DEBUG_RESSET_MODE;

    [Header("____以下はそれぞれ設定____")]
    [SerializeField]
    [Header("アニメーションスクリプト")]
    AnimationSC animationSC;

    [SerializeField]
    [Header("スマイル田中")]
    GameObject smileBall;

    [SerializeField]
    [Header("ポーズボタン")]
    GameObject pauseButton;

    [SerializeField]
    [Header("ゲージイメージ")]
    GameObject gaugeImage;

    [SerializeField]
    [Header("サイドカメラ")]
    GameObject SubCamera;

    [SerializeField]
    [Header("飛ばす力(デフォルト値 8)")]
    float power = 8.0f;

    [SerializeField]
    [Header("フレームレート制限値")]
    int targetFrameRate = 60;

    [SerializeField]
    [Header("サウンドスクリプト")]
    AudioMain soundSC;

    [SerializeField]
    [Header("ステージセレクトのタイトルオブジェクト")]
    private GameObject stageSelectPanelObject;

    [SerializeField]
    [Header("ステージオブジェクトのスクリプト")]
    StageMain selectSC;

    [SerializeField]
    [Header("力加減を示すゲージのオブジェクト(OutSide)")]
    GameObject gaugeOutsideObject;

    [SerializeField]
    [Header("力加減を示すゲージのイメージオブジェクト(Inside)")]
    Image gaugeInsideImage;

    [SerializeField]
    [Header("ゲームモードのbool")]
    public bool gameMode = true;

    public static SmileMoveMain instance;


    [Header("_________________________")]

    //プライベート変数
    [Header("____Private変数____")]
    [SerializeField]
    public int shotCounter;

    [SerializeField]
    private bool _mouseflg = false;
    [SerializeField]
    private bool _rightCursor = false;
    [SerializeField]
    private bool isStartGame;

    [SerializeField]
    private float _maxPullDistance = 1;
    [SerializeField]
    private float _powerRate;
    [SerializeField]
    private float _speedRate;

    [SerializeField]
    private Vector2 _mouseStartPos;
    [SerializeField]
    private Vector2 _mousePos;

    [SerializeField]
    private Vector3 _ResetPos = new Vector3(-7.25f, 114.91f, 9.8f);
    [SerializeField]
    private Vector3 _destination;

    [SerializeField]
    private Rigidbody2D _smileBody;

    // フレームレート表示系
    [Header("____フレームレート表示用変数____")]
    [Header("FPS")]
    [SerializeField]
    private float _fps;
    [SerializeField]
    [Header("更新頻度")]
    private float _updateRate = 0.5f;
    [SerializeField]
    private float _deltaTime = 0.0f;
    [SerializeField]
    private float _fpsTimer = 0.0f;
    // 時速表示系
    [Header("____時速表示用変数____")]
    [SerializeField]
    [Header("1コマ前のポジション")]
    private Vector3 _latestPos;
    [Header("速度")]
    [SerializeField]
    private float _speed;
    // タイム表示系
    [Header("____タイム表示用変数____")]
    [SerializeField]
    [Header("タイム")]
    public float _time;
    [SerializeField]
    [Header("タイマー起動")]
    public bool isRunningTimer;
    // 落下回数
    [Header("落下回数")]
    public int deathCount;

    [Header("以下はスクリプト制御なのでいじらない")]
    public bool rightWall;
    public bool triggerWall;
    public bool triggerFloor;
    public bool isPauseGame;
    public bool _gorogoroCalled;
}
