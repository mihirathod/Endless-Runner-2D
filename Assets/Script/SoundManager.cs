using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static  AudioClip CoinSound;
    public  static AudioSource AudSrc;

    void Start()
    {
        CoinSound = Resources.Load<AudioClip>("CoinSound");
        AudSrc = GetComponent<AudioSource>();


    }

    // Update is called once per frame
    void Update()
    {

    }
    public static void Playsound(string clip)
    {
        switch (clip)
        {
            case "Coinsound":
                AudSrc.PlayOneShot(CoinSound);
                break;
        }
    }
}
