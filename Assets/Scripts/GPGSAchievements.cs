using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;

public class GPGSAchievements : MonoBehaviour
{
    public void OpenAchievementPanel()
    {
        Social.ShowAchievementsUI();
    }

    public void updateIncremental()
    {
        PlayGamesPlatform.Instance.IncrementAchievement(GPGSIds.achievement_incremental, 1, null);
    }


    public void UnlockRegular()
    {
        Social.ReportProgress(GPGSIds.achievement_regular, 100f, null);
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
