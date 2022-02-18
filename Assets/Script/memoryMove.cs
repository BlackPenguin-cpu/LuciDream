using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class memoryMove : Objects
{
    public string SceneName;
    public float x, y;

    public override void Interaction()
    {
        base.Interaction();
        PlayerMove();
    }

    void PlayerMove()
    {
        SoundManager.Instance.PlaySound("MiDaatDoor");
        Player.Instance.transform.position = new Vector3(x, y);
        SceneManager.LoadScene(SceneName);
    }
}
