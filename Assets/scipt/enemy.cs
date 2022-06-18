using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
   
    public float speed;
    public bool grounded;
    public Collider2D groundCheck;
    public LayerMask groundLayer;
    public bool triggered;
    public Collider2D trigger;
    


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
    
    private void Update()
    {
        grounded = groundCheck.IsTouchingLayers(groundLayer);
        
        if (grounded == true)
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.down * 0;
            GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
        }
        if(triggered == true)
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.down * 0;
            GetComponent<Rigidbody2D>().velocity = Vector2.up * 0;
        }
    }
            

}
