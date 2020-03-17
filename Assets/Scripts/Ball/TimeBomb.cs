using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeBomb : NormalBall
{
    public GameObject panel;
    protected override void TimeBombZ()
    {

        detonationTime -= Time.deltaTime;
        if (detonationTime < 0)
        {
          
            if (!playParticle)
            {
                
                fireworksAll = Instantiate(fireworks);
                fireworksAll.transform.parent = this.transform;
                StartCoroutine(StopParticleSystem());
                playParticle = true;
               
            }
         
                
            

        }
    }
    IEnumerator StopParticleSystem()
    {
        yield return new WaitForSeconds(.5f);
        this.gameObject.SetActive(false);
        GameObject.Destroy(transform.GetChild(0).gameObject);
        panel.gameObject.SetActive(false);
    }
}
