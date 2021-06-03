using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boom_Damage : MonoBehaviour
{
    public float time = 0;
    // Start is called before the first frame update
    void Start()
    {
        time = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (time - Time.time <= -5.0f)
        Destroy(this.gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
         other.transform.SendMessage("TakeDamage", 50.0f, SendMessageOptions.DontRequireReceiver);
    }
}
