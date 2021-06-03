using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class tounge_fire : MonoBehaviour
{
    public GameObject Tongue;
    public GameObject punchTounge;
    public Transform Spawn;
    public GameObject sound;
    public float fireTime = 0.5f;
    private bool isFiring = false;

    private void SetFiring()
    {
        isFiring = false;
    }
    private void Punch()
    {
        isFiring = true;
        sound.GetComponent<AudioSource>().Play();
        Instantiate(punchTounge, Spawn.position, Spawn.rotation);

        Invoke("SetFiring", fireTime);
    }
    private void sticky()
    {
        isFiring = true;
        sound.GetComponent<AudioSource>().Play();
        Instantiate(Tongue, Spawn.position, Spawn.rotation);

        Invoke("SetFiring", fireTime);
    }

    void Update()
    {
        if (!isFiring)
        {
            if (Input.GetAxisRaw("Fire1") > 0)
            {
                sticky();
            }
            else if (Input.GetAxisRaw("Fire2") > 0)
            {
                Punch();
            }
        } 
    }
}
