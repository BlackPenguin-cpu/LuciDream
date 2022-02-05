using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ArrowKeyManager : MonoBehaviour
{
    public List<Sprite> ArrowImage;
    public List<int> ArrowKeyArray;
    public List<GameObject> Arrow;
    public int KeyCount;
    public int level = 0;
    public int Maxlevel = 0;
    public GameObject ArrowUI;
    public GameObject Timer;
    public GameObject Bar;
    public bool KeyDown = false;
    private int Count = 0;
    private int Multiply = 1;
    private bool Reset = true;
    void Start()
    {

    }
    void Update()
    {
        if(Timer.GetComponent<ChickenTimer>().Second <= 0 && Reset)
        {
            KeyDown = false;
            Bar.transform.DOMove(new Vector3(960,1280,0),1).SetEase(Ease.InBack);
            Timer.SetActive(false);
            Debug.Log("너 실패 ㅅㄱ");
            Reset = false;
        }
        if (level == Maxlevel)
        {
            level = 0;
            Bar.transform.DOMove(new Vector3(960,1280,0),1).SetEase(Ease.InBack);
            Timer.SetActive(false);
        }
        if (KeyDown)
        {
            ArrowKeyDown();
        }
    }

    void KeyBoard()
    {
        for (int i = 0; i < KeyCount; i++)
        {
            int RandomArrow = Random.Range(0, 4);
            ArrowKeyArray.Add(RandomArrow);
            Arrow.Add(null);
            ArrowUI.GetComponent<Image>().sprite = ArrowImage[RandomArrow];
            Arrow[i] = Instantiate(ArrowUI) as GameObject;
            Arrow[i].transform.SetParent(Bar.transform, false);
        }

        KeyDown = true;
    }


    public void Click()
    {
        Bar.SetActive(true);
        Bar.transform.DOMove(new Vector3(960, 830, 0), 1).SetEase(Ease.OutBack);
        KeyBoard();
        Timer.SetActive(true);
    }

    void ArrowKeyDown()
    {
        if (Count == KeyCount)
        {
            foreach (GameObject ArrowColor in Arrow)
            {
                Destroy(ArrowColor);
            }

            for (int i = 0; i < 3 * Multiply; i++)
            {
                ArrowKeyArray.RemoveAt(0);
            }
            Multiply++;
            level++;
            Count = 0;
            KeyCount += 3;
            KeyDown = false;
            if (level < Maxlevel)
            {
                KeyBoard();
            }
        }

        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            Debug.Log("asdf0");
            Check(0);
        }

        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            Debug.Log("asdf1");
            Check(1);
        }

        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            Debug.Log("asdf2");
            Check(2);
        }

        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            Debug.Log("asdf3");
            Check(3);
        }
    }

    void Check(int a)
    {

        if (ArrowKeyArray[Count] == a)
        {
            Debug.Log("맞음?");
            Arrow[Count].GetComponent<Image>().color = Color.black;
            Count++;
        }
        else if (ArrowKeyArray[Count] != a)
        {
            Debug.Log("응 틀림");
            Count = 0;
            foreach (GameObject ArrowColor in Arrow)
            {
                ArrowColor.GetComponent<Image>().color = new Color(255, 255, 255);
            }
        }
    }
}
