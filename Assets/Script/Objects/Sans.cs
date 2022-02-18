using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sans : Misc
{
    int endingCount;
    [SerializeField] GameObject GasterBlaster;
    Animator animator;
    protected override void Start()
    {
        base.Start();
        animator = GetComponent<Animator>();
    }
    public override void Interaction()
    {
        base.Interaction();
    }
    protected override IEnumerator TextPrint()
    {
        endingCount = 0;
        foreach (bool check in AlbumManager.Instance.unlock)
        {
            if (check)
            {
                endingCount++;
            }
        }
        Speech = new List<string>();
        switch (endingCount)
        {
            case 0:
                Speech.Add("�� �ȳ�?");
                Speech.Add("�� �����.");
                Speech.Add("���ٱ� ����.");
                break;
            case 1:
                Speech.Add("�հŸ��ε� ��� ���°͵� ��ġ���ʾ�?");
                //Speech.Add("��� �̰��� ���°ž�?");
                Speech.Add("�ƴ� ó���ΰǰ�? �� �ƾ�");
                break;
            case 2:
                Speech.Add("�ʰ� ���� ��� ���°� ������ ���� �ʾ�");
                Speech.Add("...����ؼ� ���� ���������� �ϴ°͵� ������ �ȵǰ� ���̾�");
                break;
            case 3:
                Speech.Add("Ȥ�� ��� ���ϴ°ǵ� �� �ʸ� ���⼭ ���������� ���ټ� ����");
                Speech.Add("�� �ʰ� ���⿡�� ������ �ð��� �����̶�°�");
                Speech.Add("\"�� ������\" �������� ");
                break;
            case 4:
                Speech.Add("���� ���� ���Ѱž�?");
                Speech.Add("�׳� ������, �� �̹� �����߾�.");
                break;
            case 5:
                Speech.Add("���� �������� �����ϰڴ�, �̰���?");
                Speech.Add("��, �������� �̰��� �´ٸ� �׶���");
                Speech.Add("������ \"������\" ���� �Ͼ����");
                Speech.Add("���� �����ϴ����� ������?");
                break;
            default:
                Speech.Add("����, ����");
                Speech.Add("���� ���� �̰ɷ� ����?");
                Speech.Add("������ �ð��� �������ڰ�");
                break;
        }
        yield return base.TextPrint();
        if(endingCount >= 6)
        StartCoroutine(Attack());
    }
    IEnumerator Attack()
    {
        animator.SetBool("isAngry", true);
        for (int i = 0; i < 100; i++)
        {
            Instantiate(GasterBlaster, gameObject.transform.position + new Vector3(0, 15, 0), Quaternion.Euler(0, 0, 120));
            yield return new WaitForSeconds(0.5f);
        }

    }
}
