using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class AlbumPlus : Singleton<AlbumPlus>
{
    public Transform Location;
    public GameObject Album;
    public List<bool> AlbumUnlock;
    public List<Sprite> AlbumImage;
    public List<string> Explanation;
    public Sprite testimage;
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
                Array++;
                if (Activation)
                {
                    Debug.Log(Array);
                    if (AlbumImage[Array] != null)
                    {
                        Album.GetComponent<Image>().sprite = AlbumImage[Array];
                        Album.GetComponent<AlbumImage>().Art = AlbumImage[Array];
                    }

                    if (AlbumImage[Array] == null)
                    {
                        Album.GetComponent<Image>().sprite = AlbumImage[0];
                        Album.GetComponent<AlbumImage>().Art = AlbumImage[0];
                    }
                    Album.GetComponent<AlbumImage>().Number = Array;
                    Album.GetComponent<AlbumImage>().Explanation = Explanation[Array];
                    Numbering.text = "#" + Array;
                    Instantiate(Album, scrollRect.content);
                }
            }
        }
        ReLoad = false;
        Numbering.text = "Number";
    }
}
