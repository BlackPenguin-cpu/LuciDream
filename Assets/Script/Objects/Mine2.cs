using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mine2 : Misc
{
    public GameObject mine;
    public override void Interaction()
    {

    }
    private void Update()
    {
        if (mine.GetComponent<Mine>().chek == true)
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
