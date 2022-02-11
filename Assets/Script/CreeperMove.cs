using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CreeperMove : MonoBehaviour
{
    
    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Move();
    }
    public void Move()
    {
        SceneManager.LoadScene("Creeper");
    }
}
