using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcidPitDamage : MonoBehaviour, IDamageHealth
{
    private int _aciddamage = 3;

    public int CauseDamage()
    {
        return _aciddamage;
    }
}
