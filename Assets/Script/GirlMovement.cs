using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirlMovement : MonoBehaviour
{
    public float Force;
    public Rigidbody2D playerRb;
    public float gravityModifier;
    public bool Isonground;
    public Animator GirlAnim;
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        GirlAnim = GetComponent<Animator>();
        Physics2D.gravity *= gravityModifier;

    }
    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began && Isonground)
        {
            playerRb.AddForce(Vector2.up * Force, ForceMode2D.Impulse);
            GirlAnim.SetTrigger("Jump_Girl_Trigg");

            Isonground = false;
        }
        if (Input.GetKeyDown(KeyCode.Space) && Isonground)
        {
            GirlAnim.SetTrigger("Jump_Girl_Trigg");
            playerRb.AddForce(Vector2.up * Force, ForceMode2D.Impulse);
            Isonground = false;

        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Ground"))
        {
            Isonground = true;
            GirlAnim.SetTrigger("Start_Girl_Trigg");

        }

    }
  
}
