using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BarController : MonoBehaviour {

    public GameObject tween;
    public float speed;
    //private Rigidbody rb;
    public float maxSpeed;


    public int onTouchDirection = 0;

    void Start() {
        //rb = GetComponent<Rigidbody>();

    }


    void FixedUpdate() {
        float moveHorizontal = Input.GetAxis("Horizontal");
        //Vector3 movement = new Vector3(moveHorizontal * 100, 0.0f, 0.0f);
        //rb.AddForce(movement * speed);
        //if (rb.velocity.magnitude > maxSpeed)
        //{
        //    rb.velocity = rb.velocity.normalized* maxSpeed;
        //}
        this.transform.Translate(moveHorizontal * Time.deltaTime * 50, 0, 0);
        this.tween.transform.position = this.transform.position;


        this.transform.Translate(onTouchDirection * Time.deltaTime * 50, 0, 0);
        this.tween.transform.position = this.transform.position;
    
    }


    public void OnTouchStart(bool isRight)
    {
        onTouchDirection = isRight ? 1 : -1;        
    }

    public void OnTouchStop()
    {
        onTouchDirection = 0;
    }


}
 