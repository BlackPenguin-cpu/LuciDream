using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChickenMisc : Objects
{
    public string Name;
    public List<string> Speech;
    public int a;
    public GameObject red;
    public string SceneName;
    public float x, y;
    protected override void Start()
    {
        base.Start();
        red.SetActive(false);
    }
    public override void Interaction()
    {
        if(a < 5)
        {
            base.Interaction();
            StartCoroutine(TextPrint());
            a++;
        }
        else
        {
            red.SetActive(true);
            Invoke("aaa", 0.5f);
            SceneManager.LoadScene(SceneName);
            Player.Instance.transform.position = new Vector3(x, y);
        }
    }

    void aaa()
    {
        red.SetActive(false);
    }
    protected virtual IEnumerator TextPrint()
    {
        yield return StartCoroutine(TalkUIManager.Instance.TextScript(Name, Speech));
    }
}
