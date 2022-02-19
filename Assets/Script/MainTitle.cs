using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MainTitle : MonoBehaviour
{
    [SerializeField] float Speed;
    [SerializeField] TextMeshPro Text;
    float Timer = 0;
    bool already;
    [SerializeField] GameObject[] Images;
    public bool StopPlayer;

    void Start()
    {
        SoundManager.Instance.Playbgm("MainBGM");
        Player.Instance.GetComponent<Rigidbody2D>().isKinematic = true;
    }

    // Update is called once per frame
    void Update()
    {
        StopPlayer = false;
        for (int i = 0; i < Images.Length; i++)
        {
            if (Images[i].gameObject.activeSelf == true)
            {
                StopPlayer = true;
            }
        }

        StartCoroutine(TextOn());
        transform.position = transform.position + new Vector3(0, Mathf.Cos(Time.time) * Time.deltaTime * Speed);
        Timer += Time.deltaTime;
        IEnumerator TextOn()
        {
            if (Timer > 5 && !already)
            {
                already = true;
                for (float i = 0; i < 1; i += 0.01f)
                {
                    Text.color = new Color(Text.faceColor.r, Text.faceColor.g, Text.faceColor.b, i);
                    yield return new WaitForSeconds(0.01f);
                }
            }
        }
    }
}
