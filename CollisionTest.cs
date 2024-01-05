using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTest : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collided with: " + collision.gameObject.name);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Batman")
        {
            Destroy(collision.gameObject);

        }

        if(collision.gameObject.tag == "Mario")
        {
            // increase the scale
            collision.gameObject.transform.localScale = new Vector2(25, 25);
        }

    }
        
   
   
}
