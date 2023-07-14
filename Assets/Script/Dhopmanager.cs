using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Dhopmanager : MonoBehaviour
{
    public int CurrentPlayerUndex;
    public GameObject[] PlayerModels;
    public PlayersBlueprint[] Playerss;
    public Button Buybutton;
    void Start()
    {
        foreach (PlayersBlueprint player in Playerss)
        {
            if (player.Price == 0)
            { 
                player.Isunlocked = true;

            }
            else
            {
                player.Isunlocked = PlayerPrefs.GetInt(player.Name, 0) == 0 ? false : true;
            }
        }
        CurrentPlayerUndex = PlayerPrefs.GetInt("SelctedPlayer", 0);
        foreach (GameObject Player in PlayerModels)
            Player.SetActive(false);
        PlayersBlueprint p = Playerss[CurrentPlayerUndex];
        if (!p.Isunlocked)
            return;

        PlayerModels[CurrentPlayerUndex].SetActive(true);
        
    }

    // Update is called once per frame
    void Update()
    {
        Locked();
    }

    public void Right()
    {
        PlayerModels[CurrentPlayerUndex].SetActive(false);

        CurrentPlayerUndex++;
        if (CurrentPlayerUndex == PlayerModels.Length)
            CurrentPlayerUndex = 0;

        PlayerModels[CurrentPlayerUndex].SetActive(true); 
        PlayersBlueprint p = Playerss[CurrentPlayerUndex];
        if (!p.Isunlocked)
            return;

        PlayerPrefs.SetInt("SelctedPlayer", CurrentPlayerUndex);

    }
    public void Left()
    {
        PlayerModels[CurrentPlayerUndex].SetActive(false);

        CurrentPlayerUndex--;
        if (CurrentPlayerUndex == -1 )
            CurrentPlayerUndex = PlayerModels.Length -1;

        PlayerModels[CurrentPlayerUndex].SetActive(true);
        PlayerPrefs.SetInt("SelctedPlayer", CurrentPlayerUndex);

    }

    public void Locked()
    {
        PlayersBlueprint p = Playerss[CurrentPlayerUndex];
        if (p.Isunlocked)
        {
            Buybutton.gameObject.SetActive(false);
        }
        else
        {
            Buybutton.gameObject.SetActive(true);
            Buybutton.GetComponentInChildren<TextMeshProUGUI>().text = "Buy-" + p.Price;
            if (p.Price <= PlayerPrefs.GetInt("Coinamount",0))
            {
                Buybutton.interactable = true;

            }
            else
            {
                Buybutton.interactable = false;
            }
        }
    }

    public void UnlockedPlayer()
    {
        PlayersBlueprint p = Playerss[CurrentPlayerUndex];

        PlayerPrefs.SetInt(p.Name, 1);
        PlayerPrefs.SetInt("SelctedPlayer", CurrentPlayerUndex);
        p.Isunlocked = true;
        PlayerPrefs.SetInt("Coinamount", PlayerPrefs.GetInt("Coinamount", 0) - p.Price);
    }
}
