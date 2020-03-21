using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mantul : MonoBehaviour
{
    public int speed = 21;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0,1) * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}