using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelOneFinish : MonoBehaviour
{
   private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("Player"))
        {
            // other.GetComponent<playermove>().score++;
            // other.GetComponent<playermove>().checkScore();
            SceneManager.LoadScene(1);
            
        }
    }
}
