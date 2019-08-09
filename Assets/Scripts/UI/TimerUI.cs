using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerUI : MonoBehaviour
{
    // Start is called before the first frame update
    Text displayTime;
    double time;
    void Start()
    {
        displayTime = GetComponent<Text>();
        time = 0;
        displayTime.text = "00.00";
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        displayTime.text = System.Math.Round(time, 2).ToString();
    }
}
