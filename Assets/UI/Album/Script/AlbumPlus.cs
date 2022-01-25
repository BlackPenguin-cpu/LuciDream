using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlbumPlus : MonoBehaviour
{
    public Transform Location;
    public List<GameObject> Album;
    private ScrollRect scrollRect;
    public int Array = 0;
    private int AlbumSave;
    void Start()
    {
        //AlbumSave = PlayerPrefs.GetInt("Album");
        scrollRect = GetComponent<ScrollRect>();
        /*for(int i = 0; i < AlbumSave - 1; i++)
        {

        }*/
    }

    void Update()
    {

    }

    public void AlbumAdd()
    {

        if (Album[Array] != null && Array < Album.Count)
        {
            Instantiate(Album[Array], scrollRect.content);
            ++Array;
            //PlayerPrefs.SetInt("Album", Array);
        }
    }
}
