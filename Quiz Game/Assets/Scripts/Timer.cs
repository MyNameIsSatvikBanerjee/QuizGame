using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public Text timerText;
    float currentTime;
    float startingTime;

    void Start()
    {
        startingTime = currentTime;
    }

    void FixedUpdate()
    {

        currentTime += 1 * Time.deltaTime;
        timerText.text = "Time: " + currentTime.ToString("0") + " s";

    }
}
