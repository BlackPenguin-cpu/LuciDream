using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bed : Objects
{
    public override void Interaction()
    {
        base.Interaction();
        TalkUIManager.Instance.IsTalk = true;
        CameraManager.Instance.isUIon = true;
        onClick_MainMenu.StartGame();
    }
}
