using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIshow2 : MonoBehaviour
{
    public TMP_Text uiPoint;
    // Start is called before the first frame update
    void Start()
    {
        uiPoint.text = "Level 2: Gold\nPoint Level 2= " + GetComponent<LevelTwoFinish>().score;
    }

    // Update is called once per frame
    void Update()
    {
        uiPoint.text = "Level 2: Gold\nPoint Level 2= " + GetComponent<LevelTwoFinish>().score;
    }
}
