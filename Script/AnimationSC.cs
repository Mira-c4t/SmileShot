using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AnimationSC : MonoBehaviour
{
    [Header("引張棒のアニメーション")]
    [SerializeField]
    private Animator _Animator;

    public void OnDrag(float x, bool right_trigger){
        if(right_trigger){
            _Animator.SetBool("RightWall", true);
        }
        else{
            _Animator.SetBool("RightWall", false);
        }
        _Animator.SetFloat("Kaitenritu", Math.Abs(x));
    }
    public void OnUp(){
        _Animator.SetFloat("Kaitenritu", 0);
    }
}
