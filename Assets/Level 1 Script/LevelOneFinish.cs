using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class LevelOneFinish : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("Player"))
        {
            //collision.collider.GetComponent<Scoreboard>().score = 0;
            SceneManager.LoadScene(2);
            Debug.Log("Congratulations its Level 2");
        }
    }
}
