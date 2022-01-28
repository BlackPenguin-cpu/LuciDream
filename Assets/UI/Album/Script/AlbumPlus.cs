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
    public List<Sprite> AlbumImage;
    private TextMeshProUGUI Numbering;
    private ScrollRect scrollRect;
    private bool ReLoad = true;
    private int Array = 0;
    void Start()
    {
        scrollRect = GetComponent<ScrollRect>();
        Numbering = Album.GetComponentInChildren<TextMeshProUGUI>();
        AlbumRoad();
    }

    void Update()
    {
    }

    public void AlbumRoad()
    {
        if (ReLoad)
        {
            foreach (bool Activation in AlbumUnlock)
            {
                ++Array;
                if (AlbumImage[Array] != null)
                {
                    Album.GetComponent<Image>().sprite = AlbumImage[Array];
                }

                if (AlbumImage[Array] == null)
                {
                    Album.GetComponent<Image>().sprite = AlbumImage[0];
                }

                if (Activation)
                {
                    Numbering.text = "#" + Array;
                    Instantiate(Album, scrollRect.content);
                }
            }
        }
        ReLoad = false;
        Numbering.text = "Number";
    }
}
