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
                Speech.Add("오 안녕?");
                Speech.Add("난 샌즈야.");
                Speech.Add("뼈다구 샌즈.");
                break;
            case 1:
                Speech.Add("먼거리인데 계속 오는것도 지치지않아?");
                //Speech.Add("계속 이곳에 오는거야?");
                Speech.Add("아니 처음인건가? 뭐 됐어");
                break;
            case 2:
                Speech.Add("너가 여기 계속 오는건 도움이 되지 않아");
                Speech.Add("...계속해서 여길 빠져나가려 하는것도 도움이 안되고 말이야");
                break;
            case 3:
                Speech.Add("혹시 몰라서 말하는건데 난 너를 여기서 빠져나가게 해줄수 없어");
                Speech.Add("곧 너가 여기에서 보내는 시간이 헛고생이라는걸");
                Speech.Add("\"뼈 저리게\" 느낄꺼야 ");
                break;
            case 4:
                Speech.Add("아직 포기 안한거야?");
                Speech.Add("그냥 포기해, 난 이미 포기했어.");
                break;
            case 5:
                Speech.Add("굳이 어려운길을 선택하겠다, 이거지?");
                Speech.Add("뭐, 다음에도 이곳에 온다면 그때는");
                Speech.Add("정말로 \"뼈아픈\" 일이 일어날꺼야");
                Speech.Add("조금 조심하는편이 좋을껄?");
                break;
            default:
                Speech.Add("좋아, 좋아");
                Speech.Add("내가 졌어 이걸로 됐지?");
                Speech.Add("끔찍한 시간을 보내보자고");
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
