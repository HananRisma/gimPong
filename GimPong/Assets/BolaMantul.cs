using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaMantul : MonoBehaviour
{
    public int speed = 10;
    public Rigidbody2D ball;
    public GameObject masterScript;

    public Animator animtr;
    // Start is called before the first frame update
    void Start()
    {
        int x = Random.Range(0, 2) * 2 - 1;
        int y = Random.Range(0, 2) * 2 - 1;   
        //int speed = Random.Range(11, 16);     
        ball.velocity = new Vector2(x, y) * speed;
        ball.GetComponent<Transform>().position = Vector2.zero;
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
        if(other.collider.name=="Kanan" || other.collider.name=="Kiri"){
                    masterScript.GetComponent<ScoringScript>().UpdateScore(other.collider.name);
            StartCoroutine(jeda());
        }
    }

    IEnumerator jeda(){
        ball.velocity = Vector2.zero;
        ball.GetComponent<Transform>().position = Vector2.zero;
        animtr.SetBool("IsMove", false);

        yield return new WaitForSeconds(1);

        int x = Random.Range(0, 2) * 2 - 1;
        int y = Random.Range(0, 2) * 2 - 1; 
        //int speed = Random.Range(11, 16); 
        ball.velocity = new Vector2(x, y) * speed;
        animtr.SetBool("IsMove", true);
      }
    }
}
