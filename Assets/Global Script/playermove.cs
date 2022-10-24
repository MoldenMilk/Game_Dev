using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class playermove : MonoBehaviour
{
    private Rigidbody rig;
    public float speed = 4;
    // public int HP = 5;
    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float xDir = Input.GetAxis("Horizontal");
        float yDir = Input.GetAxis("Vertical");

        Vector3 moveDir = new Vector3(xDir, 0.0f, yDir);

        //transform.position += moveDir * speed;
        rig.AddForce(moveDir * speed); 
    }

    // public void OnCollisionEnter(Collision collision)
    // {
    //     if (collision.gameObject.tag == "Enemy" || collision.gameObject.tag == "Guard")
    //     {
    //         HP--;
    //         // uiPoint.text = "HP : " + HP + "\nPoint : " + score;
    //         Debug.Log("Hit");
    //         if (HP <= 0)
    //         {
    //             // uiPoint.text = "HP : 0\nPoint : " + score + "\nGAME OVER";
    //             SceneManager.LoadScene(0);
    //         }
    //     }
    // }
}
