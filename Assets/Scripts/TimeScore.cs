using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeScore : MonoBehaviour
{
    public Text timeText;
    private float timer;
    public int time;

    private void Start()
    {
        timeText.text = "Time: 0";
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > 1f)  //add 1 every one second
        {
            time += 1;
            timeText.text = "Time: " + time.ToString("0");   //only changing the text if the score changed
            timer = 0;  //reset the time to 0
        }
    }
}
