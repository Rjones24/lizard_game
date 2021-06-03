using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    public bool enemy = true;
    public GameObject sound;
    public void Die()
    {
        if (enemy)
        {
            objectiveSystem.poachersKilled += 1;
            objectiveSystem.poachersRemaining -= 1;

        } 
        Destroy(gameObject);

    }
}
