using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballController : MonoBehaviour
{
    public Rigidbody2D rb;

    public float ballSpeed;

    public float variance = 10;

    private Vector2 travelVector = new Vector2(1, 0);
    void Start()
    {
        
    }

    void Update()
    {
        //if(rb.velocity.x == 0f && Input.GetMouseButton(0))
        //{
        //    rb.velocity = new Vector2(2f, 0f);
        //}

        transform.Translate(travelVector.normalized * ballSpeed * Time.deltaTime);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        travelVector = collision.transform.right + new Vector3(Random.Range(-variance, variance), Random.Range(-variance, variance),0);
    }

}
