using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawDamage : MonoBehaviour, IDamageHealth
{
    private int _sawDamage = 1;

    // concrete implementation of damage

    public int CauseDamage()
    {
        return _sawDamage;
    }
}
