using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Scoreboard : MonoBehaviour
{
    /*public TMP_Text uiPoint;
    
    public int scoreReq = 4;*/
    public int score;
    public int scoreUpdate;
    TMP_Text uiPoint;
    public void checkScore()
    {
        Debug.Log(" Score = " + score);
        /*
        if (score >= scoreReq)
        {
            uiPoint.text = "\nPoint : " + score + "\nLEVEL COMPLETED";
            Debug.Log("FINISHHHH");
        }*/
    }


}
