using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIshow5 : MonoBehaviour
{
    public TMP_Text uiPoint;
    // Start is called before the first frame update
    void Start()
    {
        uiPoint.text = "Level 5: Radiant\nHP= " + GetComponent<CheckHP5>().HP + "\nPoint Level 5= " + GetComponent<LevelFivcFinish>().score5;
    }

    // Update is called once per frame
    void Update()
    {
        uiPoint.text = "Level 5: Radiant\nHP= " + GetComponent<CheckHP5>().HP + "\nPoint Level 5= " + GetComponent<LevelFivcFinish>().score5;
    }
}
