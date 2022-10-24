using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CheckPoint : MonoBehaviour
{
    public int scoreReq=4;
    int score;
    int scoreUpdate;
    TMP_Text uiPoint;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("Player"))
        {
            collision.collider.GetComponent<Scoreboard>().score++;
            collision.collider.GetComponent<Scoreboard>().checkScore();
            Destroy(gameObject);
        }
    }
}

