using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectOverTime : MonoBehaviour
{
    public float timetolive;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timetolive = Time.deltaTime;
        if (timetolive < 0)
        {
            Die();
            Destroy(gameObject);
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
