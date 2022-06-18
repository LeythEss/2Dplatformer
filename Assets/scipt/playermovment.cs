using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovment : MonoBehaviour
{
    public float speed;
    public float smooth;
    public float jumpForce;
    Rigidbody2D rb2d;
    Animator anim;
    bool facingRight = true;
    bool grounded;
    public Collider2D groundCheck;
    public LayerMask groundLayer;
    bool isrunning = false;
    int numberOfJump = 1;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponentInChildren<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
  
    
    private void Update()
    {
        
        
        float x = Input.GetAxisRaw("Horizontal");
        anim.SetBool("running", x != 0);
        anim.SetBool("jumping", !grounded);
        Vector2 targetVelocity = new Vector2(x * speed, rb2d.velocity.y);
        rb2d.velocity = Vector2.SmoothDamp(rb2d.velocity, targetVelocity, ref targetVelocity, Time.deltaTime * smooth);
        if (Input.GetKeyDown(KeyCode.LeftShift) && isrunning == false)
        {
            speed = speed * 2f;
            isrunning = true;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift)&& isrunning == true)
        {
            speed = speed / 2f;
            isrunning = false;
        }
        if (x > 0 && !facingRight)
        {
            // ... flip the player.
            Flip();
        }
        // Otherwise if the input is moving the player left and the player is facing right...
        else if (x < 0 && facingRight)
        {
            // ... flip the player.
            Flip();
        }
        // Is the player touching the ground ?
        grounded = groundCheck.IsTouchingLayers(groundLayer);

        // Only jump if the player is grounded and has pressed the Space bar

        if (Input.GetKeyDown(KeyCode.Space) && (grounded || numberOfJump > 1))
        {
            rb2d.AddForce(new Vector2(0f, jumpForce));
            numberOfJump--;
            
            
        }
        if (grounded)
            numberOfJump = 2;
            

    }

    void Flip()
    {
        //Invert the facingRight variable
        facingRight = !facingRight;

        //Flip the Character
        Vector2 scale = transform.localScale;

        scale.x *= -1;

        transform.localScale = scale;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "star")
        {
            Destroy(collision.gameObject);
            gameObject.tag = "powerup";
            gameObject.GetComponentInChildren<SpriteRenderer>().material.color = Color.yellow;
            StartCoroutine("reset");
        }
    }
    IEnumerator reset()
    {
        yield return new WaitForSeconds(5f);
        gameObject.tag = "Player";
        gameObject.GetComponentInChildren<SpriteRenderer>().material.color = Color.white;
    }
}
