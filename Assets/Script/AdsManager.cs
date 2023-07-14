using UnityEngine;
using UnityEngine.Advertisements;
public class AdsManager : MonoBehaviour 
{
    private string PlaystoreID = "4276509";
    private string Interstitial_Android = "Video";
    public bool  IstestAD = false;

   
    private void Start()
    {
        Advertisement.Initialize(PlaystoreID, IstestAD);
    }
    public void DisplayVideoAds()
    {
        if (Advertisement.IsReady())
        {
            Advertisement.Show(Interstitial_Android);
        }
        else
        {
            print("Forece");
        }
       
    }
   
}

