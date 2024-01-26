using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class StageMain : MonoBehaviour
{
    public void PressEscape()
    {
        AudioScript.PressEscapeSound();
        if(isPauseGame){
            ResumeGame();
            return;
        }
        else{
            PauseGame();
            return;
        }
    }
    public void GoalLetsGo()
    {
        AudioScript.clearSound_Start();
        ClearMenu();
    }
}
