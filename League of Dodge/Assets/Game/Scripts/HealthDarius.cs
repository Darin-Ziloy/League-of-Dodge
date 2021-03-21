using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthDarius : MonoBehaviour
{

    public int MaxHealth = 1500;
    public int currentHealth;
    public HealthBar healthBar;
    public UI uI;
    void Start()
    {
        currentHealth = MaxHealth;
        healthBar.setMaxHealth(MaxHealth);
    }


    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other) 
    {
        if(other.tag == "Enemy")
        {
            TakeDamegeDarius(100);
        }
        
        if(other.tag == "Spell")
        {
            TakeDamegeDarius(200);
        }

        if(currentHealth <= 101)
        {
            uI.DeathScreen();
        }
    }


    public void TakeDamegeDarius(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHeath(currentHealth);
    }
}
