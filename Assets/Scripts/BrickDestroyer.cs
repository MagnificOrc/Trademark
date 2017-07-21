using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickDestroyer : MonoBehaviour {

    public PointCounter counter;
    void OnCollisionEnter(Collision other)
    {
        counter.Add();
        Destroy(gameObject);
    }        
    
}

