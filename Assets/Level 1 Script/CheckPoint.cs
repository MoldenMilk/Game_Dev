using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
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

