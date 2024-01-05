using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerJumpingBehavior : PlayerController
{
    
    private float _jumpForce = 300;

    [SerializeField] private CircleCollider2D _feetCollider;

    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        
    }

    // Update is called once per frame
    protected override void Update()
    {
        
    }

    // reading input from Jump action
    private void OnJump(InputValue _inputValue)
    {
        // If player not in ground then don't jump
        if (!_feetCollider.IsTouchingLayers(LayerMask.GetMask("Ground")))
        {
            // if in air
            return;
        }

        // ----

        if (_inputValue.isPressed)
        {
            // perform the jump - add force to rigidbody on Y axis
            _playerRigidbody.AddForce(Vector2.up * _jumpForce, ForceMode2D.Force);
        }
    }
}
