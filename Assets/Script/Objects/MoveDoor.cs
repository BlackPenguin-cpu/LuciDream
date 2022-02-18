using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading.Tasks;

public class MoveDoor : Objects
{
    public string SceneName;
    public float x, y;

    public override void Interaction()
    {
        base.Interaction();
        PlayerMove();
    }

    async void PlayerMove()
    {
        await Task.Delay(1000);
        Player.Instance.CoroutineQuit();
        Player.Instance.transform.position = new Vector3(x, y);
        SceneManager.LoadScene(SceneName);
    }
}
