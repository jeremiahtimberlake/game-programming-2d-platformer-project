using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerRunningBehavior : PlayerController
{
    private Vector2 _movementVector; // storing inputs from the new input system
    private float _movementSpeed = 5;

    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        
    }

    // Update is called once per frame
    protected override void Update()
    {
        
    }

    private void FixedUpdate()
    {
        // continuous physics based movements for player's rigidbody velocity (X axis)
        // apply only x axis input and retain the velocity of the rigidbody on Y
        _playerRigidbody.velocity = new Vector2(_movementVector.x * _movementSpeed, _playerRigidbody.velocity.y);

        // invoke the method here
        AlignPlayerFacingDirection();
    }

    // read movement inputs from new input system
    private void OnMove(InputValue _inputValue)
    {
        _movementVector = _inputValue.Get<Vector2>();
        //Debug.Log(_inputValue.Get<Vector2>());

    }

    // modify the scale only when player is providing inputs
    private void AlignPlayerFacingDirection()
    {
        // read the local scale and pass in movement vector x

        if (_movementVector.x != 0)
        {
            transform.localScale = new Vector2(Mathf.Sign(_movementVector.x), 1);
        }

    }
}
