using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerMovement : MonoBehaviour
{
    public float Force;
    public Rigidbody2D playerRb;
    public float gravityModifier;
    public bool Isonground;
    public Animator BoyAnim;
   
    
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        BoyAnim = GetComponent<Animator>();
        Physics2D.gravity *= gravityModifier;
        
    }
    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began && Isonground)
        {
            BoyAnim.SetTrigger("Jump_Trigg");

            playerRb.AddForce(Vector2.up * Force, ForceMode2D.Impulse);
            
            Isonground = false;
        }
        if (Input.GetKeyDown(KeyCode.Space) && Isonground)
        {
            BoyAnim.SetTrigger("Jump_Trigg");

            playerRb.AddForce(Vector2.up * Force, ForceMode2D.Impulse);
            Isonground = false;
            
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("Ground") )
        {
            Isonground = true;
            BoyAnim.SetTrigger("Run_Trigg");
            
        }
        
    }
   

}