using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoreboard : MonoBehaviour
{
    public int score = 0;

    public void checkScore()
    {
        Debug.Log(" Score = " + score);
    }


}
