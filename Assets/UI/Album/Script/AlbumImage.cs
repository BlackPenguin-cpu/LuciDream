using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AlbumImage : MonoBehaviour
{
    public GameObject CloseUpImage;
    public int Number;
    public string Explanation;
    public Sprite Art;
    void Start()
    {
        CloseUpImage = GameObject.Find("AlbumCanvas").transform.Find("CloseUp").gameObject;
    }

    void Update()
    {
        
    }

    public void CloseUp()
    {
        CloseUpImage.SetActive(true);
        CloseUpImage.GetComponentInChildren<Text>().text = Explanation;
        CloseUpImage.GetComponent<Image>().sprite = Art;
        CloseUpImage.transform.Find("Numbering").gameObject.GetComponent<Text>().text = "#" + Number;
    }
}
