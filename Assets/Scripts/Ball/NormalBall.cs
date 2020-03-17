﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class NormalBall : MonoBehaviour
{
  
    public static NormalBall main;
    [HideInInspector]
    public int throwCount, hitCount, missCount;
    public float detonationTime = 5;
    public ParticleSystem fireworks;
    public ParticleSystem fireworksAll;
    [HideInInspector]
    public bool playParticle;
    [HideInInspector]
    public bool ballThrown, ballReachedTop;
    public GameObject objectToActivate;

    private Rigidbody2D rb;
    private Quaternion originalRotationValue;
    private Vector3 originalPositionValue;
    private SpriteRenderer sprite;

    Vector2 startPos, endPos, direction;

    [Header("Sounds")]
    public GameObject swingSound , scoreSound;

    // score text 

    void Awake()
    {
        Input.multiTouchEnabled = false;
    }

    void Start()
    {
        originalRotationValue = Quaternion.Euler(Vector3.zero);   
        originalPositionValue = Vector3.zero;
        sprite = GetComponent<SpriteRenderer>();
       
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
       if(!ballThrown)
            Throw();
    }
    private void Update()
    {
        TimeBombZ();
        RotateVel();

       if(missCount < 0)
        {
            missCount = 0;
        }
    }


    protected virtual void Throw()
    {
        if (Input.touchCount == 1   && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            startPos = Input.GetTouch(0).position;
        } 
        else if (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            endPos = Input.GetTouch(0).position;
        }


        direction = startPos - endPos;
      

        if (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Ended && direction.magnitude >= 450f 
            && !EventSystem.current.IsPointerOverGameObject(Input.GetTouch(0).fingerId))
        {
              
            ballThrown = true;
            rb.AddForce(-direction.normalized * 32.5f, ForceMode2D.Impulse);   
            sprite.sortingOrder = 3;
            throwCount++;
            Instantiate(swingSound, transform.position, Quaternion.identity);
            startPos = endPos = direction = Vector2.zero;
        }


    }

    protected virtual void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Hoop")
        {
            StartCoroutine(ActivationRoutine());
            ScoreManager.Instance.AddScore(1);
            Instantiate(scoreSound, transform.position, Quaternion.identity); 
            detonationTime = 5;
                  
        }

       
    }
    private IEnumerator ActivationRoutine()
    {
        
        yield return new WaitForSeconds(.5f);

        
        objectToActivate.SetActive(true);

       
        yield return new WaitForSeconds(1);

        
        objectToActivate.SetActive(false);
    }
    void ResetBomb()
    {
        
        detonationTime = 5;                                                      
        gameObject.GetComponent<Animator>().Play("bomb", -1, 0);
       
    }   

    public virtual void ResetAll()
    {
        StartCoroutine(ResetUtil());
    }

    IEnumerator ResetUtil()
    {
        yield return new WaitForSeconds(1.8f);

        rb.isKinematic = true;
        rb.velocity = Vector2.zero;
        rb.angularVelocity = 0f;
        this.transform.position = originalPositionValue;
        this.transform.rotation = originalRotationValue;

        rb.isKinematic = false;
        ballThrown = false;
        ballReachedTop = false;
        missCount = throwCount - hitCount;
    

    }

    protected virtual void RotateVel()
    {

    }
    protected virtual void TimeBombZ()
    {



    }
}