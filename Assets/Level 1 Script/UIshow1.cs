using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIshow1 : MonoBehaviour
{
    public TMP_Text uiPoint;

    // Start is called before the first frame update
    void Start()
    {
        uiPoint.text = "Level 1: Silver\nPoint Level 1= " + GetComponent<Scoreboard>().score;
    }

    // Update is called once per frame
    void Update()
    {
        uiPoint.text = "Level 1: Silver\nPoint Level 1= " + GetComponent<Scoreboard>().score;
    }
}
