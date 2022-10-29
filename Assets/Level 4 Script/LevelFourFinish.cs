using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelFourFinish : MonoBehaviour
{
    public int score4 = 0;
    public int scoreReq4 = 8;

    public void checkScore4()
    {
        Debug.Log("Score = " + score4);
        if(score4 >= scoreReq4)
        {
            SceneManager.LoadScene(5);
        }
    }
}
