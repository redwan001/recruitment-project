using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBall : NormalBall
{
  
   protected override void RotateVel()
    {
       GetComponent<Rigidbody2D>().AddTorque(100);

    }
 
}
