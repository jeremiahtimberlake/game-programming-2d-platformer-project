using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZParentClass : MonoBehaviour
{
    //protected
    protected float _myHealth = 100; //can be accessed by child class

    // Start is called before the first frame update
    protected virtual void Start()
    {
        // child class can override this method
        Debug.Log("running from PARENT class");
        
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        
    }
}
