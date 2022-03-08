using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{

    public static int scoreValue;
    public Text score;

    void Start()
    {
    }

    void Update()
    {
        score.text = "Score: " + scoreValue.ToString(); 
    }
}
