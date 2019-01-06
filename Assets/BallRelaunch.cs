using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRelaunch : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        other.transform.position = new Vector3(0, -7, 0);
        BallScript.xspeed = 16.0f;
        BallScript.yspeed = -16.0f;
        BallScript.launchtimer = 1.0f;
        GameManager.lives--;
    }
}
