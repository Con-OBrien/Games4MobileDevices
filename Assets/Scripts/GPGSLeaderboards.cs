using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GPGSLeaderboards : MonoBehaviour
{
    public void OpenLeaderboard()
    {
        Social.ShowLeaderboardUI();
    }
    public void UpdateLeaderboardScore()
    {
        if (PlayerPrefs.GetInt("ScoreToUpdate", 0) == 0)
        {
            return;
        }

        Social.ReportScore(PlayerPrefs.GetInt("ScoreToUpdate", 1), GPGSIds.leaderboard_high_score, (bool success) =>
        {
            if (success)
            {
                PlayerPrefs.SetInt("ScoreToUpdate", 0);
            }
        });
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
