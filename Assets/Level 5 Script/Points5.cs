using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points5 : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("Player"))
        {
            collision.collider.GetComponent<LevelFivcFinish>().score5++;
            collision.collider.GetComponent<LevelFivcFinish>().checkScore5();
            Destroy(gameObject);
        }
    }
}
