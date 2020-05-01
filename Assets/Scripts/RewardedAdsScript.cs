using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.UI;
using TMPro;

public class RewardedAdsScript : MonoBehaviour, IUnityAdsListener
{
    string gameId = "3583226";
    bool testMode = true;
    public string myPlacementId = "rewarded_Ad";
    public static int score = 0;
    public TextMeshProUGUI scoreText;
    public Text textThing;
    // Initialize the Ads listener and service:
    void Start()
    {
       // Advertisement.AddListener(this);
      //  Advertisement.Initialize(gameId, testMode);
    }
    public void ShowAd()
    {
        Advertisement.Initialize(gameId, testMode);
    }

    // Implement IUnityAdsListener interface methods:
    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        // Define conditional logic for each ad completion status:
        if (showResult == ShowResult.Finished)
        {
            score++;
            textThing.text = score.ToString();
            scoreText.text = score.ToString();
            // Reward the user for watching the ad to completion.
        }
        else if (showResult == ShowResult.Skipped)
        {
            // Do not reward the user for skipping the ad.
        }
        else if (showResult == ShowResult.Failed)
        {
            Debug.LogWarning("The ad did not finish due to an error.");
        }
    }

    public void OnUnityAdsReady(string placementId)
    {
        // If the ready Placement is rewarded, show the ad:
        if (placementId == myPlacementId)
        {
            Advertisement.Show(myPlacementId);
        }
    }

    public void OnUnityAdsDidError(string message)
    {
        // Log the error.
    }

    public void OnUnityAdsDidStart(string placementId)
    {
        // Optional actions to take when the end-users triggers an ad.
    }
}
