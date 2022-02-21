using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissingPoster : Misc
{
    public int num;
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

    public override void Interaction()
    {
        base.Interaction();
    }
    protected override IEnumerator TextPrint()
    {
        Check();
        yield return base.TextPrint();
        gameObject.SetActive(false);
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
                StartCoroutine(Slander());
                break;
            default:
                break;
        }
    }

    IEnumerator Slander()
    {
        SoundManager.Instance.Playbgm("SlanderSound");

        GameObject Man = Instantiate(SlanderMan, Camera.main.transform.position + new Vector3(0,0,10), Quaternion.identity);
        Player.Instance.Dead = true;
        yield return new WaitForSeconds(1);
        Man.SetActive(false);
        yield return new WaitForSeconds(1);
        Man.SetActive(true);
        Man.transform.localScale = new Vector2(2.5f,2.5f);
        yield return new WaitForSeconds(1);
        Man.SetActive(false);
        yield return new WaitForSeconds(1);
        Man.SetActive(true);
        Man.transform.localScale = new Vector2(5f,5f);

        DeathManager.Instance.OnDeathUI(17,"키 큰 백인 아저씨하고 데이트하는 경험도 그리 나쁘지는 않죠?");
    
    }

    IEnumerator JumpScare()
    {
        Vector3 pos = Player.Instance.transform.position + new Vector3(Random.Range(14, -14), Random.Range(7, -7));
        GameObject Jumpobj = Instantiate(JumpScareSlanderMan, pos, Quaternion.identity);
        yield return new WaitForSeconds(5);

        Destroy(Jumpobj);
    }
}
