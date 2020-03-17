using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControll : MonoBehaviour
{

    Vector2 startPos, endPos, direction;
    float touchTimeStart, touchTimeFinish, timeInterval;
   

    private Rigidbody2D rb;

    private void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
         
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            touchTimeStart = Time.time;
            startPos = Input.GetTouch(0).position;
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            touchTimeFinish = Time.time;
            timeInterval = touchTimeFinish - touchTimeStart;
            endPos = Input.GetTouch(0).position;
            endPos = new Vector2(endPos.x, Mathf.Clamp(transform.position.y, 0f, 4.2f));
            direction = startPos - endPos ;

            GetComponent<Rigidbody2D>().AddForce(-direction   *8f);
        }
    }


}

