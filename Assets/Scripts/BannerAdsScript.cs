using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
public class BannerAdsScript : MonoBehaviour
{
    string gameId = "3583226";
    bool testMode = true;
    public string myPlacementId = "banner_Ad";
    public void ShowAd()
    {
        Advertisement.Initialize(gameId, testMode);
        Advertisement.Show(myPlacementId);
        StartCoroutine(ShowBannerWhenReady());
    }
    void Start()
    {
       // Advertisement.Initialize(gameId, testMode);
       // StartCoroutine(ShowBannerWhenReady());
    }

    IEnumerator ShowBannerWhenReady()
    {
        while (!Advertisement.IsReady(myPlacementId))
        {
            yield return new WaitForSeconds(0.5f);
        }
        Advertisement.Banner.SetPosition(BannerPosition.BOTTOM_CENTER);
        Advertisement.Banner.Show(myPlacementId);
    }
}
