using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sans : Misc
{
    int endingCount;
    public override void Interaction()
    {
        base.Interaction();
        endingCount = 0;
        foreach (bool check in AlbumManager.Instance.unlock)
        {
            if (check)
            {
                endingCount++;
            }
        }
        Speech = null;
        switch (endingCount)
        {
            case 0:
                Speech.Add("�� �ȳ�?");
                Speech.Add("�� �����.");
                Speech.Add("���ٱ� ����.");
                break;
            case 1:
                Speech.Add("��� �̰��� ���°ž�?");
                Speech.Add("�ƴ� ó���ΰǰ�? �� �ƾ�");
                break;
            case 2:
                Speech.Add("�ʰ� ���� ��� ���°� ������ ���� �ʾ�");
                Speech.Add("...����ؼ� ���� ���������� �ϴ°͵� ������ �ȵǰ� ���̾�");
                break;
            case 3:
                Speech.Add("Ȥ�� ���� ���ϴ°ǵ� �� �ʸ� ���⼭ ���������� ���ټ� ����");
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
                Speech.Add("�����δ� �ٽô� ������");
                break;
        }
    }

    IEnumerator Attack()
    {

    }

}
