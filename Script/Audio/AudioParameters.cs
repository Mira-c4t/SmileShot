using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class AudioMain : MonoBehaviour
{
    [Header("サウンドオブジェクト")]
    [SerializeField]
    GameObject SoundObj;
    [Header("サウンド")]
    [Header("0 : ゲームBGM")]
    [Header("1 : ゴロゴロ")]
    [Header("2 : チャージ音")]
    [Header("3 : ポーズBGM")]
    [Header("4 : バウンド音")]
    [Header("5 : くりあ～")]
    [Header("6 : おめでと～")]
    [Header("7 : 長押しチャージ用の音")]
    [Header("8 : クリア時の拍手")]
    [Header("9 : 穴に落ちた時の音")]
    [Header("10 : メニューボタンを押した時の音")]
    [Header("11 : Escapeでメニューを呼び出した時の音")]

    [SerializeField]
    private List<AudioClip> Sounds;

    [Header("オーディオソース(いじらない)")]
    [SerializeField]
    private List<AudioSource> AudioSources = new List<AudioSource>();
}
