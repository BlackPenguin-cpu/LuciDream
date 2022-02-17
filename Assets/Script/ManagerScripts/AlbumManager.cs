using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlbumManager : Singleton<AlbumManager>
{

    public GameObject albumContainer;

    void Start()
    {
        ContainerOff();
    }

    void Update()
    {
        
    }

    public void ContainerOff()
    {
        albumContainer.SetActive(false);    
    }

    public void ContainerOn()
    {
        albumContainer.SetActive(true);
    }
}
