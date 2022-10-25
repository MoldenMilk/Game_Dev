using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIshow4 : MonoBehaviour
{
    public TMP_Text uiPoint;
    // Start is called before the first frame update
    void Start()
    {
        uiPoint.text = "Level 4: Ascendant\nHP= " + GetComponent<CheckHP4>().HP + "\nPoint Level 4= " + GetComponent<LevelFourFinish>().score4;
    }

    // Update is called once per frame
    void Update()
    {
        uiPoint.text = "Level 4: Ascendant\nHP= " + GetComponent<CheckHP4>().HP + "\nPoint Level 4= " + GetComponent<LevelFourFinish>().score4;
    }
}
