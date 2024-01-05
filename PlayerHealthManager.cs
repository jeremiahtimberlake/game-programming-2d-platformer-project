using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthManager : MonoBehaviour
{
    // broadcasting class

    // STEP 1: create an event
    public static event Action PlayerDied;

    // cause damage to health when overlapped with traps
    private int _playerHealth = 20;

    public int GetPlayerHealth()
    {
        return _playerHealth;
    }

    // Start is called before the first frame update
    void Start()
    {
  
        
    }

    // Update is called once per frame
    void Update()
    {
        // STEP 2: include a condition to raise the event
        if (_playerHealth <=0)
        {
            // let everyone know that the player died

            // raise the event
            if (PlayerDied != null)
            {
                PlayerDied();
            }
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // part where player runs into the trap
        // extract the damage amount and pass it to the method below

        int _damage = collision.gameObject.GetComponent<IDamageHealth>().CauseDamage();
        DamagePlayerHealth(_damage);
    }

    private void DamagePlayerHealth(int _damageAmount)
    {
        _playerHealth -= _damageAmount;
    }
}
