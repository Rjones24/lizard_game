using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Burn : MonoBehaviour
{

    private float damage = 5f;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag=="Player")
        {
            other.transform.SendMessage("TakeDamage", damage, SendMessageOptions.DontRequireReceiver);
        }
        
    }
}
