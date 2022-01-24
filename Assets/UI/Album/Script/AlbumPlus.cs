using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlbumPlus : MonoBehaviour
{
    public Transform Location;
    public GameObject Album;
    private ScrollRect scrollRect;
    void Start()
    {
        scrollRect = GetComponent<ScrollRect>();
    }

    void Update()
    {
        
    }

    public void AlbumAdd()
    {
        Instantiate(Album, scrollRect.content);
        
    }
}
