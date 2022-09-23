using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballController : MonoBehaviour
{
    public Rigidbody2D rb;

    void Start()
    {
        
    }

    void Update()
    {
        if(rb.velocity.x == 0f && Input.GetMouseButton(0))
        {
            rb.velocity = new Vector2(2f, 0f);
        }
    }
}
