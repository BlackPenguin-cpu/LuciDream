using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bed : Objects
{
    protected override void Interaction()
    {
        onClick_MainMenu.StartGame();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
