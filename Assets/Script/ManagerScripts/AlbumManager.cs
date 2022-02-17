using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlbumManager : Singleton<AlbumManager>
{
    public List<bool> unlock;
    public List<Sprite> image;
    public List<string> explanation;
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
