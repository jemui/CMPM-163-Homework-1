using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public bool top = false;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        // Move the object upward in world space 1 unit/second.
        if( transform.position.y < 1.5 && top == false ) {
            transform.Translate(0, Time.deltaTime/2, 0, Space.World);
           
        } else {
            transform.Translate(0, -Time.deltaTime/2, 0, Space.World);
            top = true;
            if(transform.position.y < 0)
                 top = false;
        }

    }
}