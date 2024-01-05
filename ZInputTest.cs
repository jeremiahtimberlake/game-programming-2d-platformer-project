using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ZInputTest : MonoBehaviour
{
    // get the reference of rigidbody2D
    private Rigidbody2D _rigidBody;
    [SerializeField]private float _force = 50;

    // Start is called before the first frame update
    void Start()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnFire(InputValue _inputValue)
    {
        if (_inputValue.isPressed)
        {

            //add force to rigidbody on X axis)right vector)
            _rigidBody.AddForce(Vector2.right * _force, ForceMode2D.Impulse);

            //Debug.Log("player fired the projectile");


        }

    }
}
