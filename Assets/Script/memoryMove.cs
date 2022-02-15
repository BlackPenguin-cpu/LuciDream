using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class memoryMove : MonoBehaviour
{
    public string SceneName;
    public float x, y;
    public void Move()
    {
        SceneManager.LoadScene(SceneName);
        Player.Instance.transform.position = new Vector3(x, y);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Move();
    }
}
