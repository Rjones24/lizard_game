using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LowerBridge : MonoBehaviour
{

    public GameObject Bridge;
    bool ButtonPressed;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Renderer>().material.color = new Color(255.0f, 0.0f, 0.0f);//red
    }

    // Update is called once per frame
    void Update()
    {
        if(ButtonPressed)
        Bridge.transform.localRotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "TonguePunch(Clone)")
        {
            ButtonPressed = true;

            gameObject.GetComponent<Renderer>().material.color = new Color(0.0f, 255.0f, 0.0f);//green
        }
    }
}
