using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public enum PlayerState
{
    IDLE,
    WALK,
    DIE,
    INTERACTIVE
}
public enum PlayerDir
{
    UP,
    DOWN,
    RIGHT,
    LEFT
}

public class Player : Singleton<Player>
{
    public float MoveSpeed;
    public float MoveTime;
    public PlayerState State;
    public PlayerDir PlayerDir;
    public bool Dead;

    private Objects InteractionObj = null;
    private Coroutine OnMouseClickIEnumerator;
    private Camera Camera;
    private List<Node> NodeList;
    private Tweener tween;
    private Animator anim;

    private void OnLevelWasLoaded(int level)
    {
        anim = GetComponent<Animator>();
        Camera = Camera.main;
    }
    private void Start()
    {
        anim = GetComponent<Animator>();
        Camera = Camera.main;
        Camera.transform.position = transform.position;
    }

    private void Update()
    {
        AnimationChecker();
        if (Input.GetMouseButtonDown(1))
        {
            if (OnMouseClickIEnumerator != null) StopCoroutine(OnMouseClickIEnumerator);
            if (!TalkUIManager.Instance.IsTalk)
            {
                OnMouseClickIEnumerator = StartCoroutine(OnMouseClick());
            }
        }
        CameraMove();
    }

    void AnimationChecker()
    {
        anim.SetInteger("State", (int)State);
        anim.SetInteger("Dir", (int)PlayerDir);

        switch (State)
        {
            case PlayerState.IDLE:
                break;
            case PlayerState.WALK:
                switch (PlayerDir)
                {
                    case PlayerDir.UP:
                        break;
                    case PlayerDir.DOWN:
                        break;
                    case PlayerDir.RIGHT:
                        break;
                    case PlayerDir.LEFT:
                        break;
                    default:
                        break;
                }
                break;
            case PlayerState.DIE:
                Dead = true;
                break;
            case PlayerState.INTERACTIVE:
                break;
            default:
                break;
        }
    }

    void CameraMove()
    {
        Camera.transform.position = Vector3.Lerp(Camera.transform.position, this.gameObject.transform.position + new Vector3(0, 0, -10), Time.deltaTime);
    }

    IEnumerator OnMouseClick()
    {
        //클릭 체크
        Vector2 mouse = Camera.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
        RaycastHit2D[] hitobjects = Physics2D.RaycastAll(mouse, Vector3.forward);

        foreach (RaycastHit2D hit in hitobjects)
        {
            GameObject obj = hit.collider.gameObject;
            if (obj.tag == "Interaction")
            {
                Objects Interactive = obj.GetComponent<Objects>();
                Interactive.OnCliked();
                InteractionObj = Interactive;
            }
        }

        //이동
        AStarTest.Instance.targetPos = Vector2Int.RoundToInt(mouse);
        AStarTest.Instance.PathFinding();
        NodeList = AStarTest.Instance.FinalNodeList;
        if (NodeList.Count > 1)
        {
            foreach (Node node in NodeList)
            {
                if (InteractionObj != null)
                {
                    if (Vector2.Distance(InteractionObj.transform.position, transform.position) <= 1.5f)
                    {
                        InteractionObj.Interaction();
                        InteractionObj = null;
                        Debug.Log("asd");
                        break;
                    }
                }
                if (node.isWall == true) break;

                Vector2 dir = new Vector2(node.x, node.y);
                VectorStateChecker(dir);
                State = PlayerState.WALK;
                if (tween != null) tween.Kill();
                tween = transform.DOMove(dir, MoveSpeed);
                yield return new WaitForSeconds(MoveTime);
                State = PlayerState.IDLE;
            }
        }
        else if (OnMouseClickIEnumerator != null) StopCoroutine(OnMouseClickIEnumerator);
    }

    void VectorStateChecker(Vector2 dir)
    {
        if (transform.position.x < dir.x)
        {
            PlayerDir = PlayerDir.RIGHT;
        }
        else if (transform.position.x > dir.x)
        {
            PlayerDir = PlayerDir.LEFT;
        }
        else if (transform.position.y > dir.y)
        {
            PlayerDir = PlayerDir.DOWN;
        }
        else if (transform.position.y < dir.y)
        {
            PlayerDir = PlayerDir.UP;
        }
    }
}

