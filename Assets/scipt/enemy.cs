using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    
   
    public float speed;
    public void Start()
    {
        
    }

    
    
    public float damage;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
            collision.gameObject.GetComponent<HealthManager>().TakeDamage(damage);
    }
    
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {


        
        GetComponent<Rigidbody2D>().velocity = Vector2.down * speed;

    }
}
