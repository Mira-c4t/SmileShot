using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public partial class SmileMoveMain : MonoBehaviour
{

    void DoAddForce(float ForcePower)
    {
        if(isPauseGame || !isStartGame){return;}
        Vector2 force = new Vector2(transform.position.y * (ForcePower * power), 0f);
        if((rightWall) || (!rightWall)){
            _smileBody.AddForce(force);
        }
    }

    void OnMouseUp()
    {
        if(isPauseGame || !isStartGame){return;}
        if (_mouseflg)
        {
            _mouseflg = false;
            animationSC.OnUp();
            if (triggerWall && triggerFloor)
            {
                shotCounter++;
                if (gameMode)
                {
                    if(rightWall){_powerRate *= -1;}
                }
                soundSC.shot();
                DoAddForce(_powerRate);
            }
            ChangeImageStrong();
        }
        soundSC.tapSound_Stop();
        soundSC.longSound_Stop();
        _powerRate = 0;
    }

    void OnMouseDown()
    {
        if(isPauseGame || !isStartGame){return;}
        if(gameMode){
            _mouseflg = true;
            soundSC.longSound_Start();
            StartCoroutine(YourCoroutine());
        }

        if (!_mouseflg && !gameMode)
        {
            _mouseflg = true;
            _mouseStartPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            soundSC.tapSound_Start();
        }
    }
    IEnumerator YourCoroutine()
    {
        bool jougen = false;
        float timePassed = 0f;
        while (_mouseflg)
        {
            timePassed += Time.deltaTime;

            if (timePassed >= 0.000000001f)  // 0.000000001f秒ごとに実行
            {
                timePassed = 0f;  // 時間をリセット

                _powerRate += jougen ? -0.015f : 0.015f;

                if (rightWall)
                {
                    gaugeInsideImage.fillOrigin = (int)Image.OriginVertical.Bottom;
                    animationSC.OnDrag(_powerRate, true);
                }
                else
                {
                    gaugeInsideImage.fillOrigin = (int)Image.OriginVertical.Top;
                    animationSC.OnDrag(_powerRate, false);
                }
                soundSC.longPitch(Mathf.Abs(_powerRate) + 0.1f);
                ChangeImageStrong(_powerRate);
                if (1 <= _powerRate)
                {
                    jougen = true;
                }
                else if (_powerRate <= 0)
                {
                    jougen = false;
                }
            }
            yield return null;  // 次のフレームまで待機
        }
    }

    void OnMouseDrag()
    {
        if(isPauseGame || !isStartGame || gameMode){return;}
        _mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (_mouseflg)
        {
            if (Vector2.Distance(_mouseStartPos, _mousePos) > _maxPullDistance)
            {
                _mousePos = (_mousePos - _mouseStartPos).normalized * _maxPullDistance + _mouseStartPos;
            }
        }
        var Force = (_mouseStartPos - (Vector2)_mousePos);
        _powerRate = Force.x;
        ChangeImageStrong(Mathf.Abs(_powerRate));
        soundSC.tapPitch(Mathf.Abs(_powerRate) + 0.1f);
        if (Force.x < 0)
        {
            animationSC.OnDrag(_powerRate, true);
            _rightCursor = true;
        }
        if (0 < Force.x)
        {
            animationSC.OnDrag(_powerRate, false);
            _rightCursor = false;
        }
    }
}
