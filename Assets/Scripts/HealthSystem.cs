using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class OnDamagedEvent : UnityEvent<int> { }
public class HealthSystem : MonoBehaviour
{
    public int health = 10;
    public int maxhealth = 10;
    public UnityEvent onDie;
    public OnDamagedEvent onDamaged;
    public GameObject healthdrop;
   
    
    
    public void TakeDamage(int damage)
    {
        health -= damage;
        onDamaged.Invoke(health);
        if (health < 1)
        {
            Instantiate(healthdrop, transform.position, Quaternion.identity);
            onDie.Invoke();
           
        }
    }

    private void checkmaxhp()
    {
        if (health > maxhealth)
        {
            health = maxhealth;
        }

       
    }

  
  
}


