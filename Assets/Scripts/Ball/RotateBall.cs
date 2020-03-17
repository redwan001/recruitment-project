using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBall : NormalBall
{
  
   protected override void RotateVel()
    {
        transform.Rotate(Vector3.forward);

    }

}
