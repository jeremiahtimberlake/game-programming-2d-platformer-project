using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Animator))]

public class PlayerController : MonoBehaviour
{
    // this behavior depends on the following components
    protected Rigidbody2D _playerRigidbody;
    protected Animator _playerAnimator;

    // Start is called before the first frame update
    protected virtual void Start()
    {
        // get the reference of rigidbody and animator using getcomponent
        _playerRigidbody = GetComponent<Rigidbody2D>();
        _playerAnimator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        
    }
}
