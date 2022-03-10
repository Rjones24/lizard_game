using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gas_Grow : MonoBehaviour
{
    bool hitMax = false;
    bool hitMin = true;
   Vector3 scaleChange = new Vector3(-0.01f, -0.01f, -0.01f);

    // Update is called once per frame
    void Update()
    {
       if( transform.localScale.x >= 12.0f)
        {
            hitMax = true;
            hitMin = false;
        }
        else if(transform.localScale.x <= 0.5f)
        {
            hitMin = true;
            hitMax = false;
        }

        if (hitMin)
        {
            transform.localScale -= scaleChange*2;
        }
        else if(hitMax)
        {
            transform.localScale += scaleChange;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            other.transform.SendMessage("TakeDamage", 2.5f, SendMessageOptions.DontRequireReceiver);
        }
    }
}
