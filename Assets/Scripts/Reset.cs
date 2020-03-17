using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{

    public CircleCollider2D ring1, ring2;
    public BoxCollider2D box1;
    private NormalBall normalBall;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        print("Colliders1 " + ring1.enabled);
        print("Colliders2 " + ring2.enabled);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            ring1.enabled = false;
            ring2.enabled = false;
            box1.enabled = false;

            normalBall = collision.gameObject.GetComponent<NormalBall>();

            print("Ball Received " + normalBall.ballReachedTop);

            if(normalBall.ballReachedTop)
            {
                normalBall.ResetAll();
                print("Ball is back");
            }
        }
    }
}
