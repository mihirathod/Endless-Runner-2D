using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour
{
    private Vector3 StartPos;
    // Start is called before the first frame update
    void Start()
    {
        StartPos = transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x< StartPos.x - 220)
        {
            transform.position = StartPos;
        }
        
    }
}