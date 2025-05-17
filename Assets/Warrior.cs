using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior : Unit
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public override void Cry()
    {
        Debug.Log("За Императора!");
    }
}
