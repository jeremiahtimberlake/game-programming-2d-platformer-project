using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerFiringBehavior : PlayerController
{
    // read player input for "fire" action
    // when input is pressed - create a bullet object
    // Instantiate command
    // spawn point
    // object to be created

    [SerializeField] private GameObject _spawnPoint;
    [SerializeField] private GameObject _bulletPrefab;

    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        
    }

    // Update is called once per frame
    protected override void Update()
    {
        
    }

    private void OnFire(InputValue _inputValue)
    {
        if (_inputValue.isPressed)
        {
            FireBullet();
        }
    }

    private void FireBullet()
    {
        // instantiate the bullet
        Instantiate(_bulletPrefab, _spawnPoint.transform.position, Quaternion.identity);
    }
    


}
