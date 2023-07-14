using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSelector : MonoBehaviour
{
    public int CurrentPlayerUndex;
    public GameObject[] Playerss;
    // Start is called before the first frame update
    void Start()
    {
        CurrentPlayerUndex = PlayerPrefs.GetInt("SelctedPlayer", 0);
        foreach (GameObject Players in Playerss)
            Players.SetActive(false);

        Playerss[CurrentPlayerUndex].SetActive(true);
    }
}
