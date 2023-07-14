using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MoveLeft : MonoBehaviour
{
    public float Speed;
    private float Bounds = -7;
    public float MaxSpeed = 30;
    void Start()
    {
    }

    void Update()
    {
        if (Speed < MaxSpeed)
        {
            Speed += 0.1f * Time.deltaTime;
        }
        


            transform.Translate(Vector2.left * Time.deltaTime * Speed); 
        if (transform.position.x < Bounds && gameObject.CompareTag("Obstacles"))
        {
            Destroy(gameObject);
        }
        if (transform.position.x < Bounds && gameObject.CompareTag("Collectables"))
        {
            Destroy(gameObject);
        }


    }
}
