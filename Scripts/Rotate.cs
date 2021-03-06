﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public bool end = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Roll the object back and forth in world space 1 unit/second.
        if( transform.position.x < 3 && end == false ) {
            transform.Translate(Time.deltaTime, 0, 0, Space.World);
            transform.Rotate(20*-Time.deltaTime, 0, 0, Space.World);
        } else {
            transform.Translate(-Time.deltaTime, 0, 0, Space.World);
            transform.Rotate(20*Time.deltaTime, 0, 0, Space.World);
            end = true;
            if(transform.position.x < 0)
                 end = false;
        } 
    }
}
