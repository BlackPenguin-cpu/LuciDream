using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pen : Misc
{
    public GameObject mine;
    public override void Interaction()
    {
        
    }
    private void Update()
    {
        if (mine.GetComponent<Pen2>().chek == true)
        {
            StartCoroutine(Hide());
        }
    }
    IEnumerator Hide()
    {
        yield return StartCoroutine(TextPrint());
        this.gameObject.SetActive(false);
    }
}
