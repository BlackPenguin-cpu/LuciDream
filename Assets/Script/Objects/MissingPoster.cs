using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissingPoster : Misc
{
    int num;
    [SerializeField] GameObject JumpScareSlanderMan;
    [SerializeField] GameObject SlanderMan;
    protected override void Start()
    {
        base.Start();
        if (Inventory.Instance.MissingPoster[num] == true)
        {
            gameObject.SetActive(false);
        }
    }

    protected override IEnumerator TextPrint()
    {
        yield return base.TextPrint();
        Check();
    }
    void Check()
    {
        Inventory.Instance.MissingPoster[num] = true;
        int cnt = 0;
        foreach (bool check in Inventory.Instance.MissingPoster)
        {
            if (check) cnt++;
        }
        switch (cnt)
        {
            case 3:
                StartCoroutine(JumpScare());
                break;
            case 4:
                StartCoroutine(JumpScare());
                break;
            case 5:
                break;
            default:
                break;
        }
        gameObject.SetActive(false);
    }

    IEnumerator Slander()
    {

        yield return new WaitForSeconds(2);
    }

    IEnumerator JumpScare()
    {
        Vector3 pos = Player.Instance.transform.position + new Vector3(Random.Range(14, -14), Random.Range(7, -7));
        GameObject Jumpobj = Instantiate(JumpScareSlanderMan, pos, Quaternion.identity);
        yield return new WaitForSeconds(3);

        Destroy(Jumpobj);
    }
}
