using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    // MeshRenderer destroyed;
    
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("Player"))
        {
            collision.collider.GetComponent<LevelTwoFinish>().score++;
            collision.collider.GetComponent<LevelTwoFinish>().checkScore();
            Destroy(gameObject);
        }
    }
}
