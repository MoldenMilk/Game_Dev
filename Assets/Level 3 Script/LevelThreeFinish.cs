using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelThreeFinish : MonoBehaviour
{
    public int score2 = 0;
    public int scoreReq2 = 8;

    public void checkScore2()
    {
        if(score2 >= scoreReq2)
        {
            SceneManager.LoadScene(3);
        }
    }
}
