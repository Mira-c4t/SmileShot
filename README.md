# このプロジェクトは「[すまいるしょっと](https://sites.google.com/da.iwasaki.ac.jp/dx2d/%E3%81%99%E3%81%BE%E3%81%84%E3%82%8B%E3%81%97%E3%82%87%E3%81%A3%E3%81%A8)」に依存しています。
ゲームのダウンロードも上記のサイトで行えます
> #~~修正の余地がありすぎて辛い！！~~
# 私が作成したコードのほぼ全てが ```partial class```を使用しています
## [SmileMove](/Script/SmileMove/)
- :このプロジェクトの最重要ソースフォルダです。主人公(スマイル)の動き等が詰まってます。
### [SmileCall.cs](/Script/SmileMove/SmileCall.cs)
- :外部のスクリプトから呼び出されるpublic関数を詰め込んでます。
### [SmileInCall.cs](/Script/SmileMove/SmileInCall.cs)
- :内部のスクリプトから呼び出されるprivate関数を詰め込んでます。
### [SmileMouseGesture.cs](/Script/SmileMove/SmileMouseGesture.cs)
- :マウスの動きを記録するスクリプトです。
### [SmileMoveMain.cs](/Script/SmileMove/SmileMoveMain.cs)
- :重要な関数をまとめたスクリプトです。
### [SmileParameters.cs](/Script/SmileMove/SmileParameters.cs)
- :変数を全て宣言したスクリプトです。
## [Audio](/Script/Audio/)
- :オーディオ関連のスクリプトが格納されています。
### [AudioCall.cs](/Script/Audio/AudioCall.cs)
- :オーディオ関連のpublic関数を詰め込んでます。
### [AudioInCall.cs](/Script/Audio/AudioInCall.cs)
- :オーディオ関連のprivate関数を詰め込んでます。
### [AudioMain.cs](/Script/Audio/AudioMain.cs)
- :オーディオ関連の主要な関数をまとめたスクリプトです。
### [AudioParameter.cs](/Script/Audio/AudioParameters.cs)
- :オーディオ関連の変数を全て宣言したスクリプトです。

## [EditorScript](/Script/EditorScript/)
- :エディター関連のスクリプトが格納されています。
### [CompileOnPlayMode.cs](/Script/EditorScript/CompileOnPlayMode.cs)
- :コードエディターから戻ってくる度にコンパイルの実行がされるのが面倒だったので```Ctrl + R```でコンパイルをするようにし、戻ってきた時にコンパイルが起こらないようにしました。


## [StageSelectMenu](/Script/StageSelectMenu/)
- :ステージ選択メニュー関連のスクリプトが格納されています。
### [StageButton.cs](/Script/StageSelectMenu/StageButton.cs)
- :ステージ選択ボタンのスクリプトです。
### [StageCall.cs](/Script/StageSelectMenu/StageCall.cs)
- :ステージ選択関連のpublic関数を詰め込んでます。
### [StageInCall.cs](/Script/StageSelectMenu/StageInCall.cs)
- :ステージ選択関連のprivate関数を詰め込んでます。
### [StageMain.cs](/Script/StageSelectMenu/StageMain.cs)
- :ステージ選択関連の主要な関数をまとめたスクリプトです。

## OtherScript
- :その他のスクリプト。
### [AnimationSC.cs](/Script/AnimationSC.cs)
- :アニメーション関連のスクリプトです。
### [Collider.cs](/Script/Collider.cs)
- :コライダー関連のスクリプトです。
### [ugokubou.cs](/Script/ugokubou.cs)
- :動く棒関連のスクリプトです。
