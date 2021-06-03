using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sticky_Tounge : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.GetComponent<Rigidbody>() != null)
        {
            gameObject.AddComponent<SpringJoint>();
            gameObject.GetComponent<SpringJoint>().connectedBody = collision.rigidbody;
        }
    }
}
