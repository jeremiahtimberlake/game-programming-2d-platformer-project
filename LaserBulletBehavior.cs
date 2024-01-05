using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserBulletBehavior : MonoBehaviour
{
    // move in the player facing direction
    private Rigidbody2D _bulletRigidBody;
    private float _bulletForce = 300;

    // player's x scale
    private float _playerXScale;

    // Start is called before the first frame update
    void Start()
    {

        _playerXScale = GameObject.FindGameObjectWithTag("Player").transform.localScale.x;
        _bulletRigidBody = GetComponent<Rigidbody2D>(); // getting bullet's rB

        // add force on X axis
        _bulletRigidBody.AddForce(Vector2.right * _bulletForce * _playerXScale);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            Destroy(gameObject); // destroy bullet
        }
    }
}
