using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disapearOverTime : MonoBehaviour
{

    public float adjustmentAngle = 0;
    [SerializeField] private float delay = 1f;
    public bool Ispoints = true;
    private float timeElapsed;

  
    private void Update()
    {
            timeElapsed += Time.deltaTime;

        if (timeElapsed > delay)
        {
                Destroy(gameObject);
        }
    }
}
