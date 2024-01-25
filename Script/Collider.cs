using UnityEngine;

public class CustomCollider : MonoBehaviour
{
    [SerializeField]
    [Header("Smile Script")]
    private SmileMoveMain _smileMoveMain;
    [Header("エフェクトオブジェクト")]
    [SerializeField]
    GameObject _effectObj;
    [SerializeField]
    [Header("サウンドスクリプト")]
    AudioMain soundSC;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject collisionObj = collision.gameObject;
        string layerName = LayerMask.LayerToName(collisionObj.layer);

        if (layerName == "Wall")
        {
            _effectObj.SetActive(true);
            _smileMoveMain.triggerWall = true;

            switch (collisionObj.tag)
            {
                case "RightWall":
                    _smileMoveMain.rightWall = true;
                    break;
                case "LeftWall":
                    _smileMoveMain.rightWall = false;
                    break;
            }
        }
        if (collisionObj.tag == "Bound")
        {
            soundSC.boundSound_Start();
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        GameObject collifionObj = collision.gameObject;
        if (collifionObj.tag == "Floor")
        {
            _smileMoveMain.triggerFloor = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        GameObject collisionObj = collision.gameObject;
        string layerName = LayerMask.LayerToName(collisionObj.layer);

        if (layerName == "Wall")
        {
            _effectObj.SetActive(false);
            _smileMoveMain.triggerFloor = false;
            _smileMoveMain.triggerWall = false;
            _smileMoveMain.rightWall = false;
        }
        if (collisionObj.tag == "Floor")
        {
            _smileMoveMain.triggerFloor = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collider){
        GameObject colliderObj = collider.gameObject;
        if (colliderObj.tag == "HOLE"){
            soundSC.deaSound();
            soundSC.downBGMPitch();
            _smileMoveMain.deathCount++;
            _smileMoveMain.ResetPosition();
        }
        if (colliderObj.tag == "GOAL")
        {
            _smileMoveMain.GoalYeah();
        }
    }
}
