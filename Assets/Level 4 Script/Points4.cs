using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points4 : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("Player"))
        {
            collision.collider.GetComponent<LevelFourFinish>().score4++;
            collision.collider.GetComponent<LevelFourFinish>().checkScore4();
            Destroy(gameObject);
        }
    }
}
