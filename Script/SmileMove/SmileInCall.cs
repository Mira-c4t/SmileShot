using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class SmileMoveMain : MonoBehaviour
{
    private void CheckInstance()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void SpeedCheck()
    {
        if(isPauseGame){ return;}
        _speedRate = Mathf.Clamp01(_smileBody.velocity.sqrMagnitude);
        if (!_gorogoroCalled && _speedRate == 1)
        {
            soundSC.Gorogoro_Start();
            _gorogoroCalled = true;
        }
        else if (_gorogoroCalled && _speedRate != 1)
        {
            soundSC.Gorogoro_Stop();
            _gorogoroCalled = false;
        }
        _latestPos = smileBall.transform.position;
    }
    private void AddTimer()
    {
        _time += Time.deltaTime;
    }
    public string FormatTime(float time)
    {
        int minutes = Mathf.FloorToInt(time / 60f);
        int seconds = Mathf.FloorToInt(time % 60f);
        float milliseconds = (time * 1000f) % 1000f;

        return string.Format("{0:00}:{1:00}:{2:000}", minutes, seconds, milliseconds);
    }
    private void ChangeImageStrong(float power = 0f)
    {
        gaugeInsideImage.fillAmount = power;
    }
}
