using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerMovement : MonoBehaviour
{
    public float Force;
    public Rigidbody2D playerRb;
    public bool Isonground;
    public Animator Playeranim;
   
    
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        Playeranim = GetComponent<Animator>();
        
    }
    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began && Isonground)
        {
            Playeranim.SetTrigger("Jump");

            playerRb.AddForce(Vector2.up * Force, ForceMode2D.Impulse);
            
            Isonground = false;
        }
        if (Input.GetKeyDown(KeyCode.Space) && Isonground)
        {
            Playeranim.SetTrigger("Jump");

            playerRb.AddForce(Vector2.up * Force, ForceMode2D.Impulse);
            Isonground = false;
            
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("Ground") )
        {
            Isonground = true;
            Playeranim.SetTrigger("Run");
            
        }
        
    }
   

}