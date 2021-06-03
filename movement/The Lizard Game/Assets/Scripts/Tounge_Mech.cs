using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tounge_Mech : MonoBehaviour
{
    public float moveSpeed;
    int Distance = 20;
    int CurrentDistance = 0;
    bool HitLimit = false;

    private void Die()
    {
        Destroy(gameObject);
    }

    void Update()
    {
        if (HitLimit == false)
        {
            transform.Translate(0f, 0f, moveSpeed);
            CurrentDistance += 1;
        }
        else if (HitLimit == true)
        {
            transform.Translate(0f, 0f, -moveSpeed);
            CurrentDistance -= 1;
        }

        if (CurrentDistance >= Distance)
        {
            
            HitLimit = true;
        }
        else if (CurrentDistance == 0)
        {
            Die();
        }
      
    }

    void OnCollisionEnter(Collision collision)
    {
        HitLimit = true;
    }
}
