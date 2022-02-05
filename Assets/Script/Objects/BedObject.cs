using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BedObject : Objects
{
    public GameObject BedUI;
    public override void Interaction()
    {
        base.Interaction();
        BedUI.SetActive(true);
    }

    public void GameStart()
    {
        SceneManager.LoadScene("Map");
    }
}
