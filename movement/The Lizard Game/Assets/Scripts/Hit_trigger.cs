using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit_trigger : MonoBehaviour
{
    public int damage;
    public float resetTime = 1.0f;

    private void OnTriggerEnter(Collider collision)
    {
        collision.transform.SendMessage("TakeDamage", damage, SendMessageOptions.DontRequireReceiver);
        GetComponent<Collider>().enabled = false;
        Invoke("ResetTrigger", resetTime);
    }

    private void ResetTrigger()
    {
        GetComponent<Collider>().enabled = true;
    }
}

