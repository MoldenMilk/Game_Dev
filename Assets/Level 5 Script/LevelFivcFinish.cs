using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelFivcFinish : MonoBehaviour
{
    public int score5 = 0;
    public int scoreReq5 = 5;

    public void checkScore5()
    {
        Debug.Log("Score = " + score5);
        if(score5 >= scoreReq5)
        {
            //ini tempat code UI
            Debug.Log("Congratulations You Win The Game");
        }
    }
}
