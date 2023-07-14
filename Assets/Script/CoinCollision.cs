using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollision : MonoBehaviour
{
    public SoundManager soundManager;


    public void Start()
    {
        soundManager = GetComponent<SoundManager>();    
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        Collactables.Coinamount += 1;
        SoundManager.AudSrc.PlayOneShot(SoundManager.CoinSound, 1);
       
    }
}
