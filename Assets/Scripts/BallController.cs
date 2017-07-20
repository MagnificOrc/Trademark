using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float speed;
    public float moveHorizontal;
    public float moveVertical;
    private Rigidbody rb;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Vector3 movement = new Vector3(Random.Range(0.1f,1), moveVertical, 0.0f);
        rb.AddForce(movement * speed);
    }
   
}