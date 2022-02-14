using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CreeperMove : MonoBehaviour
{
    public string SceneName;
    public float x, y;
    public GameObject Image;
    private void Start()
    {
        Image.SetActive(false);
        Time.timeScale = 1;
    }
    public void Move()
    {
        SceneManager.LoadScene(SceneName);
        Player.Instance.transform.position = new Vector3(x, y);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Image.SetActive(true);
        Time.timeScale = 0;
    }

    public void ok()
    {
        Move();
    }

    public void no()
    {
        Image.SetActive(false);
        Time.timeScale = 1;
    }
}
