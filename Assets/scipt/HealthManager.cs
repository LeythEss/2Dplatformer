using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HealthManager : MonoBehaviour
{
    const float MaxHealth = 100f;
    float health;
    public Slider healthSlider;
    // Start is called before the first frame update
    void Start()
    {
        health = MaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
  
    void Die()
    {
        GetComponent<playermovment>().enabled = false;
        GetComponentInChildren<Animator>().SetBool("isdead", true);
    }
    public void TakeDamage(float amount)
    {
        health -= amount;

        if (health <= 0)
        {
            health = 0;
            Die();
        }
        healthSlider. = health / MaxHealth;
    }
    
}
