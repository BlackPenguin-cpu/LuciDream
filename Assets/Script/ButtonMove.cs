using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonMove : Objects
{
    public string SceneName;
    public float x, y;
    public override void Interaction()
    {
        base.Interaction();
        Move();
    }

    public void Move()
    {
        SceneManager.LoadScene("SceneName");
        Player.Instance.transform.position = new Vector3(x, y);
    }
}
