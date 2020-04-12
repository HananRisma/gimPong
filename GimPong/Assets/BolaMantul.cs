using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaMantul : MonoBehaviour
{
    public int speed = 10;
    public Rigidbody2D ball;

    public Animator animtr;
    // Start is called before the first frame update
    void Start()
    {
        ball.velocity = new Vector2(-1,-1) * speed;
        animtr.SetBool("IsMove", true);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(ball.velocity.x > 0){ //bola ke kanan
            ball.GetComponent<Transform>().localScale = new Vector3(28,30,1);

        }else{
             ball.GetComponent<Transform>().localScale = new Vector3(-28,30,1);
    }

    void OnCollisionEnter2D(Collision2D other) {
        if(other.collider.name=="rightWall" || other.collider.name=="leftWall"){
            StartCoroutine(jeda());
        }
    }

    IEnumerator jeda(){
        ball.velocity = Vector2.zero;
        ball.GetComponent<Transform>().position = Vector2.zero;
        animtr.SetBool("IsMove", false);
        yield return new WaitForSeconds(1);
        ball.velocity = new Vector2(-1,-1) * speed;
        animtr.SetBool("IsMove", true);
      }
    }
}
