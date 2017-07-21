using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointCounter : MonoBehaviour {
    public int points;

    public Text scoreText;
    
    void FixedUpdate()
    {
        UpdateScore();
    }

    public void Add()
    {
        points += 1;
        
    }
    void UpdateScore()
    {
        scoreText.text = "Score: " + points;
    }


}
