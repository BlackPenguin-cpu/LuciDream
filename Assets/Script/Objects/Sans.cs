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
                Speech.Add("오 안녕?");
                Speech.Add("난 샌즈야.");
                Speech.Add("뼈다구 샌즈.");
                break;
            case 1:
                Speech.Add("계속 이곳에 오는거야?");
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
                Speech.Add("앞으로는 다시는 오지마");
                break;
        }
    }

    IEnumerator Attack()
    {

    }

}
