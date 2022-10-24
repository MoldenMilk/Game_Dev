using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelTwoFinish : MonoBehaviour
{
    public int score = 0;
    public int scoreReq = 10;

    public void checkScore()
    {
        Debug.Log("Score = " + score);
        
        if(score >= scoreReq)
        {
            SceneManager.LoadScene(2);
        }
    }
}
