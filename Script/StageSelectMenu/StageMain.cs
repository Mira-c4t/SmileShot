using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public partial class StageMain : MonoBehaviour
{
    private void SelectStage(int stageNumber)
    {
        _stageObjects[stageNumber].SetActive(true);
        _triggerObjects[stageNumber].SetActive(true);
        _SelectPanel.SetActive(false);
        StartGame();
        _smileBallSC.ResetPosition();
    }
    public IEnumerator GetEnumerator()
    {
        // _stageObjectsに対するIEnumeratorを返すコードを実装してください
        return _stageObjects.GetEnumerator();
    }

    public void ResetScene() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
