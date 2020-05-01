using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
public class InterstitialAdsScript : MonoBehaviour
{
    string gameId = "3583226";
    bool testMode = true;
    public string myPlacementId = "interstitial_Ad";
    public void ShowAd()
    {
        Advertisement.Initialize(gameId, testMode);
        Advertisement.Show(myPlacementId);
    }
}
