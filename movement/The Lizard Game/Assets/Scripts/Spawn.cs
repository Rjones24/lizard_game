using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    public GameObject prefabToSpawn;
    public float adjustmentAngle = 0;
    public GameObject sound;


    public void Spawner()
    {
        sound.GetComponent<AudioSource>().Play();
        Vector3 rotationInDeg = transform.eulerAngles;
        rotationInDeg.x += adjustmentAngle;
        Quaternion rotationInRad = Quaternion.Euler(rotationInDeg);

        Instantiate(prefabToSpawn, transform.position, rotationInRad);
    }

}
