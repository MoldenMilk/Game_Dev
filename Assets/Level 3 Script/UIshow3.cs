using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIshow3 : MonoBehaviour
{
    public TMP_Text uiPoint;
    // Start is called before the first frame update
    void Start()
    {
        uiPoint.text = "Level 3: Diamond\nHP= " + GetComponent<CheckHPScene>().HP + "\nPoint Level 3= " + GetComponent<LevelThreeFinish>().score2;
    }

    // Update is called once per frame
    void Update()
    {
        uiPoint.text = "Level 3: Diamond\nHP= " + GetComponent<CheckHPScene>().HP + "\nPoint Level 3= " + GetComponent<LevelThreeFinish>().score2;
    }
}
