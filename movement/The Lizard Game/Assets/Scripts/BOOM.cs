using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BOOM : MonoBehaviour
{
    int i = 0;
    float time = 0;
    bool bomActive = false;
    public GameObject explosion;
    // Start is called before the first frame update
    void Start()
    {
        i = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (bomActive)
        {
            i++;
            if (i % 2 == 0)
            {
                gameObject.GetComponent<Renderer>().material.color = new Color(255.0f, 0.0f, 0.0f);//red
            }
            else
            {
                gameObject.GetComponent<Renderer>().material.color = new Color(255.0f, 255.0f, 0.0f);//red}
            }

            if (time - Time.time <= -2.0f)
            {
                GameObject entry = Instantiate(explosion);
                entry.transform.SetPositionAndRotation(this.gameObject.transform.localPosition, this.gameObject.transform.localRotation);
                Destroy(this.gameObject);
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "TonguePunch(Clone)")
        {
            bomActive = true;
            time = Time.time;
        }
    }
}
