using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hoopSound : MonoBehaviour
{
    public GameObject hoopSounds;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
            Instantiate(hoopSounds, transform.position, Quaternion.identity);
    }

}
