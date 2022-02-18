using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveDoor : Objects
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
        Player.Instance.CoroutineQuit();
        Player.Instance.transform.position = new Vector3(x, y);
        SceneManager.LoadScene(SceneName);
    }
}
