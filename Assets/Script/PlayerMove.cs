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

public class PlayerMove : MonoBehaviour
{
    public float MoveSpeed;
    public PlayerState State;
    private Coroutine OnMouseClickIEnmerator;
    [SerializeField] Camera Camera;

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
        {
            if (OnMouseClickIEnmerator != null) StopCoroutine(OnMouseClickIEnmerator);
            OnMouseClickIEnmerator = StartCoroutine(OnMouseClick());
        }
    }

    IEnumerator OnMouseClick()
    {

        yield return new WaitForSeconds(MoveSpeed);
    }
    IEnumerator OnWalk(Vector2 Dir)
    {
        yield return null;
    }

}
