using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

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
    public PlayerDir PlayerDir;
    public bool Dead;
    public bool CanNotMove;
    private PlayerState State;
    float die = 0;
    public PlayerState _State
    {
        get { return State; }
        set
        {
            if (value == PlayerState.DIE)
            {
                return;
            }
            State = value;
        }
    }


    private Objects InteractionObj = null;
    private Coroutine OnMouseClickIEnumerator;
    private List<Node> NodeList;
    private Tweener tween;
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        AnimationChecker();
        if (Input.GetMouseButtonDown(1))
        {
            die = 0;
            if (!TalkUIManager.Instance.IsTalk && State != PlayerState.DIE)
            {
                if (OnMouseClickIEnumerator != null) StopCoroutine(OnMouseClickIEnumerator);

                if (SceneManager.GetActiveScene().name == "TitleMap")
                {
                    if (!FindObjectOfType<MainTitle>().StopPlayer && !CanNotMove)
                    {
                        OnMouseClickIEnumerator = StartCoroutine(OnMouseClick());
                    }
                }
                else
                    OnMouseClickIEnumerator = StartCoroutine(OnMouseClick());
            }
        }
        InteractionDetected();

        die += Time.deltaTime;
        if (die > 60)
        {
            print("죽음");
        }
    }
    void InteractionDetected()
    {
        if (InteractionObj != null)
        {
            if (Vector2.Distance(InteractionObj.transform.position, transform.position) <= 1.6f)
            {
                State = PlayerState.IDLE;
                InteractionObj.Interaction();
                InteractionObj = null;
                if(OnMouseClickIEnumerator != null)
                {
                    StopCoroutine(OnMouseClickIEnumerator);
                }
            }
        }
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
                if (OnMouseClickIEnumerator != null) StopCoroutine(OnMouseClickIEnumerator);
                break;
            case PlayerState.INTERACTIVE:
                break;
            default:
                break;
        }
    }



    IEnumerator OnMouseClick()
    {
        //클릭 체크
        Vector2 mouse = Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
        RaycastHit2D[] hitobjects = Physics2D.RaycastAll(mouse, Vector3.forward);

        if (InteractionObj != null)
        {
            InteractionObj.isClicked = false;
            InteractionObj._isOutLine = false;
        }

        foreach (RaycastHit2D hit in hitobjects)
        {
            GameObject obj = hit.collider.gameObject;
            if (obj.tag == "Interaction")
            {
                InteractionObj = obj.GetComponent<Objects>();
                InteractionObj.OnCliked();
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

    public void CoroutineQuit()
    {
        if (tween != null)
            tween.Kill();
        if (OnMouseClickIEnumerator != null)
            StopCoroutine(OnMouseClickIEnumerator);
        State = PlayerState.IDLE;
    }
}

