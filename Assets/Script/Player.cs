using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

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
        if (Input.GetMouseButtonDown(2))
        {
            if (OnMouseClickIEnumerator != null) StopCoroutine(OnMouseClickIEnumerator);
            OnMouseClickIEnumerator = StartCoroutine(OnMouseClick());
        }
    }

    IEnumerator OnMouseClick()
    {
        NodeList = AStarTest.Instance.FinalNodeList;
        if (NodeList.Count > 0)
        {
            foreach (Node node in NodeList)
            {
                //transform
                yield return new WaitForSeconds(MoveSpeed);
            }
        }
        else StopCoroutine(OnMouseClickIEnumerator);
    }
    IEnumerator OnWalk(Vector2 Dir)
    {
        yield return null;
    }

}
