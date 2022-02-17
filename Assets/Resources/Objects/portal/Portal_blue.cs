using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Portal_blue : MonoBehaviour
{
    public GameObject MainCamera;
    private void Start()
    {
        MainCamera.GetComponent<Inventory>().portal = true;
    }
}
