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
            // other.GetComponent<playermove>().score++;
            // other.GetComponent<playermove>().checkScore();
            Destroy(gameObject);
            
            
        }
    }
}
