using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Monika : MonoBehaviour
{
    [SerializeField] TextMeshPro text;
    [SerializeField] Image monikaJJin;

    public void Textp()
    {
        StartCoroutine(ExitTextEdit());
    }
    IEnumerator ExitTextEdit()
    {
        TextMeshPro a1 = Instantiate(text, new Vector3(Random.Range(3, -3), Random.Range(2, -2)), Quaternion.identity);
        yield return StartCoroutine(Textprint("��¥ ��������?", a1));
        yield return new WaitForSeconds(1);
        TextMeshPro a2 = Instantiate(text, new Vector3(Random.Range(3, -3), Random.Range(2, -2)), Quaternion.identity);
        yield return StartCoroutine(Textprint("������ �� �ÿ��� ���۵Ȱ� ������?", a2));
        yield return new WaitForSeconds(1);
        TextMeshPro a3 = Instantiate(text, new Vector3(Random.Range(3, -3), Random.Range(2, -2)), Quaternion.identity);
        yield return StartCoroutine(Textprint("�����ϰ� �ð����� ���鼭 ����� �̵��Ŷ�� ������� ���� �����ϰھ�", a3));
        yield return new WaitForSeconds(1);
        TextMeshPro a4 = Instantiate(text, new Vector3(Random.Range(3, -3), Random.Range(2, -2)), Quaternion.identity);
        yield return StartCoroutine(Textprint("�ð��� �ʹ� ������", a4));
        yield return new WaitForSeconds(1);

        Destroy(a1);
        Destroy(a2);
        Destroy(a3);
        Destroy(a4);

        TextMeshPro a5 = Instantiate(text, new Vector3(Random.Range(7, -7), Random.Range(4, -4)), Quaternion.identity);
        yield return StartCoroutine(Textprint("�ٵ� ��ǥ �� �����ϼ̰�! ��ǥ �ð� ��� �˼��ؿ�Ф� ŷ��!", a5));
        yield return new WaitForSeconds(1);
        monikaJJin.gameObject.SetActive(true);

    }
    IEnumerator Textprint(string text, TextMeshPro obj)
    {
        string app = null;
        int target = 0;
        while (app != text)
        {
            app += text[target];
            target++;
            obj.text = app;
            yield return new WaitForSeconds(0.1f);
        }
    }
}
