using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using DG.Tweening;

public enum PlayerState
{
    IDLE,
    WALK,
    DIE
}

public class Player : Singleton<Player>
{
    public float MoveSpeed;
    public PlayerState State;
    private Coroutine OnMouseClickIEnumerator;
    [SerializeField] Camera Camera;
    public List<Node> NodeList;
    private Tweener tween;

    private void OnLevelWasLoaded(int level)
    {
        Camera = Camera.main;
    }
    private void Start()
    {
        Camera = Camera.main;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (OnMouseClickIEnumerator != null) StopCoroutine(OnMouseClickIEnumerator);
            OnMouseClickIEnumerator = StartCoroutine(OnMouseClick());
        }
        CameraMove();
    }

    void CameraMove()
    {
        Camera.transform.position = Vector3.Lerp(Camera.transform.position, this.gameObject.transform.position + new Vector3(0,0,-10), Time.deltaTime);
    }

    IEnumerator OnMouseClick()
    {
        Vector2 mouse = Camera.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
        AStarTest.Instance.targetPos = Vector2Int.RoundToInt(mouse);
        AStarTest.Instance.PathFinding();
        NodeList = AStarTest.Instance.FinalNodeList;
        if (NodeList.Count > 0)
        {
            foreach (Node node in NodeList)
            {
                Debug.Log("아라라라");
                if (tween != null) tween.Kill();
                tween = transform.DOMove(new Vector2(node.x, node.y), MoveSpeed);
                yield return tween;
                yield return new WaitForSeconds(MoveSpeed);
            }
        }
        else StopCoroutine(OnMouseClickIEnumerator);
    }
}
