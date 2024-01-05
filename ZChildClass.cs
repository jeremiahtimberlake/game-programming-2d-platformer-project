using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZChildClass : ZParentClass
{
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        //Debug.Log("running start method from CHILD class");
        
    }

    // Update is called once per frame
    protected void Update()
    {
        
    }
}
