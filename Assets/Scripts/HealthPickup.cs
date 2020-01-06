using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour
{
   
    public int damage = 10;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            other.transform.SendMessage("TakeDamage", damage, SendMessageOptions.DontRequireReceiver);
            Die();
        }
    }
    private void OnBecameInvisible()
    {
        Die();
    }

    private void Die()
    {
        Destroy(gameObject);
    }
}
