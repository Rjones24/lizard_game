﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_look : MonoBehaviour

{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float LookVertical = Input.GetAxisRaw("Controller Y") ;
    
        transform.Rotate(-LookVertical /6, 0f, 0f, Space.Self);
    }
}