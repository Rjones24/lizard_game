using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform Target;
    public float smoothing = 5.0f;
    public float adjustmentangle = 0.0f;
    public bool playerClose = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            playerClose = true;
           
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            playerClose = false;
         
        }
    }

    void Update()
    {
        if (playerClose)
        {


            if (Target != null)
            {
                Vector3 difference = Target.position - transform.position;

                float rotateY = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;

                Quaternion newRotation = Quaternion.Euler(new Vector3(0.0f, rotateY + adjustmentangle, 0.0f));

                transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, Time.deltaTime * smoothing);
            }
        }
    }

    private void FixedUpdate()
    {
        if (playerClose)
        {
            Vector3 newposition = new Vector3(Target.position.x, transform.position.y, Target.position.z);
            transform.position = Vector3.Lerp(transform.position, newposition, (smoothing * 0.005f));
        }
    }
}
