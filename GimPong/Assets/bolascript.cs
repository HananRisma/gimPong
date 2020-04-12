using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bolascriptt : MonoBehaviour
{
    public int speed=10;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello Game!");
        GetComponent<Rigidbody2D>().velocity = new Vector2(1,-1) * speed;
        
    }

    // Update is called once per frame
    void Update()
    {
   
    }

    void OnCollisionEnter2D(Collision2D other) {
        if(other.collider.name=="rightWall" || other.collider.name=="leftWall"){
            GetComponent<Transform>().position = new Vector2(0,0);
        }
    }
}