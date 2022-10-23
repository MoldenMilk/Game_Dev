using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points2 : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision2)
    {
        if(collision2.collider.CompareTag("Player"))
        {
            collision2.collider.GetComponent<LevelThreeFinish>().score2++;
            collision2.collider.GetComponent<LevelThreeFinish>().checkScore2();
            Destroy(gameObject);
        }
    }
}
