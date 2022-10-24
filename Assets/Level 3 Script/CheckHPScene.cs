using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckHPScene : MonoBehaviour
{
    public int HP = 5;

     public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy" || collision.gameObject.tag == "Guard")
        {
            HP--;
            // uiPoint.text = "HP : " + HP + "\nPoint : " + score;
            Debug.Log("Hit");
            Debug.Log("HP = " + HP);
            if (HP <= 0)
            {
                // uiPoint.text = "HP : 0\nPoint : " + score + "\nGAME OVER";
                SceneManager.LoadScene(2);
            }
        }
    }
}
