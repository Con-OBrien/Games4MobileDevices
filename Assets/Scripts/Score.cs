using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public static int score = 0;
    public TextMeshProUGUI scoreText;
    public Text textThing;

    public void incrementScore()
    {
        score++;
        textThing.text = score.ToString();
        scoreText.text = score.ToString();

        PlayerPrefs.SetInt("ScoreToUpdate", PlayerPrefs.GetInt("ScoreToUpdate", 0) + 1);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
