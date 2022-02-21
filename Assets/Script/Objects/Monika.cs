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
        yield return StartCoroutine(Textprint("진짜 나가려고?", a1));
        yield return new WaitForSeconds(1);
        TextMeshPro a2 = Instantiate(text, new Vector3(Random.Range(3, -3), Random.Range(2, -2)), Quaternion.identity);
        yield return StartCoroutine(Textprint("이제야 막 시연이 시작된거 같은데?", a2));
        yield return new WaitForSeconds(1);
        TextMeshPro a3 = Instantiate(text, new Vector3(Random.Range(3, -3), Random.Range(2, -2)), Quaternion.identity);
        yield return StartCoroutine(Textprint("구차하게 시간까지 끌면서 만든게 이딴거라니 사람들이 뭐라 생각하겠어", a3));
        yield return new WaitForSeconds(1);
        TextMeshPro a4 = Instantiate(text, new Vector3(Random.Range(3, -3), Random.Range(2, -2)), Quaternion.identity);
        yield return StartCoroutine(Textprint("시간을 너무 끌었네", a4));
        yield return new WaitForSeconds(1);

        Destroy(a1);
        Destroy(a2);
        Destroy(a3);
        Destroy(a4);

        TextMeshPro a5 = Instantiate(text, new Vector3(Random.Range(7, -7), Random.Range(4, -4)), Quaternion.identity);
        yield return StartCoroutine(Textprint("다들 발표 다 수고하셨고! 발표 시간 끌어서 죄송해요ㅠㅠ 킹아!", a5));
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
