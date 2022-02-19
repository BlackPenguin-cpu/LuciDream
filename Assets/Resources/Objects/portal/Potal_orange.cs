using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potal_orange : Objects
{
    public GameObject game;

    protected override void Start()
    {
        game = Player.Instance.gameObject;
        base.Start();
     //   GameObject.Find("Player").GetComponent<Transform>().transform.position = game.transform.position;
    }
    public override void Interaction()
    {
        Player.Instance.CoroutineQuit();
        SoundManager.Instance.PlaySound("Warp");
        game.transform.position = new Vector3(7, -0.55f, -1);
    }
}
