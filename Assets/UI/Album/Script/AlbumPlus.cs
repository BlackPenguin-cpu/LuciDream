using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlbumPlus : MonoBehaviour
{
    public Transform Location;
    public List<GameObject> Album;
    private ScrollRect scrollRect;
    private int Array = 0;
    void Start()
    {
        scrollRect = GetComponent<ScrollRect>();
    }

    void Update()
    {

    }

    public void AlbumAdd()
    {

        if (Album[Array] != null && Array < Album.Count)
        {
            Instantiate(Album[Array], scrollRect.content);
            Array++;
            Debug.Log("¤±¤¤¤·¤©");
        }
    }
}
