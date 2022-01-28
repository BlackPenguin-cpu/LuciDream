using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class AlbumPlus : MonoBehaviour
{
    public Transform Location;
    public GameObject Album;
    public List<bool> AlbumUnlock;
    public List<Texture2D> AlbumImage;
    private TextMeshProUGUI Numbering;
    private ScrollRect scrollRect;
    private bool ReLoad = true;
    private int Array = 0;
    void Start()
    {
        scrollRect = GetComponent<ScrollRect>();
        Numbering = Album.GetComponentInChildren<TextMeshProUGUI>();
        AlbumAdd();
    }

    void Update()
    {
    }

    public void AlbumAdd()
    {
        if (ReLoad)
        {
            foreach (bool Activation in AlbumUnlock)
            {
                if (Activation)
                {
                    Numbering.text = "#" + ++Array;
                    Instantiate(Album, scrollRect.content);
                }
            }
        }
        ReLoad = false;
        Numbering.text = "Number";
    }
}