using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hoop : MonoBehaviour
{


    public CircleCollider2D ring1, ring2;
    public BoxCollider2D box;
    public SpriteRenderer spr;

    private void Start()
    {
      
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {

            print("Disabled");
            spr.sortingOrder = 1;
            ring1.enabled = true;
            ring2.enabled = true;
            box.enabled = true;
        }
    }
}
