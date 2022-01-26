using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlbumPlus : MonoBehaviour
{
    public Transform Location;
    public List<GameObject> Album;
    public List<bool> AlbumUnlock;
    public int Array = 0;
    private ScrollRect scrollRect;
    private int AlbumSave;
    private bool ReLoad = true;
    void Start()
    {
        scrollRect = GetComponent<ScrollRect>();
        
    }

    void Update()
    {
    }

    public void AlbumAdd()
    {
        if (ReLoad)
        {
        foreach(bool Activation in AlbumUnlock)
        {
            if (Activation)
            {
                Instantiate(Album[Array], scrollRect.content);
                Array++;
            }
        }
        }
        ReLoad = false;
        Array = 0;
    }
}
