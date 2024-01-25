# このプロジェクトは「[すまいるしょっと](https://github.com/Mira-c4t/SmileShot/blob/main/README.md)」に依存しています。

Unityで使用したAssetsフォルダーを有料アセットを抜いてアップロードしました

# スクリプト系は```Assets/Script```にあります
# 私が作成したコードのほぼ全てが ```partial class```を使用しています
## [SmileMove](Assets/Script/SmileMove)
このプロジェクトの最重要ソースフォルダです
主人公(スマイル)の動き等が詰まってます
### [SmileCall.cs](Assets/Script/SmileMove/SmileCall.cs)
外部のスクリプトから呼び出されるpublic関数を詰め込んでます
### [SmileInCall.cs](Assets/Script/SmileMove/SmileInCall.cs)
内部のスクリプトから呼び出されるprivate関数を詰め込んでます
### [SmileMouseGesture.cs](Assets/Script/SmileMove/SmileMouseGesture.cs)
マウスの動きを記録するスクリプトです
### [SmileMoveMain.cs](Assets/Script/SmileMove/SmileMoveMain.cs)
重要な関数をまとめたスクリプトです
### [SmileParameters.cs](Assets/Script/SmileMove/SmileParameters.cs)
変数を全て宣言したスクリプトです
## [EditorScript](Assets/Script/EditorScript/CompileOnPlayMode.cs)
コードエディターから戻ってくる度にコンパイルの実行がされるのが面倒だったので```Ctrl + R```でコンパイルをするようにし、戻ってきた時にコンパイルが起こらないようにしました。
