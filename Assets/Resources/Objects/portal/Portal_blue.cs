using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Portal_blue : MonoBehaviour
{
    private void Start()
    {
        Invoke("aaa", 3);
    }

    void aaa()
    {
        DeathManager.Instance.OnDeathUI(DeathManager.Instance.DeathList[30]);
    }
}
