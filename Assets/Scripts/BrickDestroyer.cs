﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickDestroyer : MonoBehaviour {

          
    void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject);
    }        
    
}
