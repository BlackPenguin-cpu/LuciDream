using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desktop : Objects
{
    public override void Interaction()
    {
        base.Interaction();
        GetComponent<onClick_MainMenu>().Opition_in();
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
