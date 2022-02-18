using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class GasterBlaster : MonoBehaviour
{
    int time;
    [SerializeField] int num;
    [SerializeField] Sprite sprite;
    [SerializeField] string Desc;
    [SerializeField] bool shoot = false;
    [SerializeField] float Speed = 1;

    private void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.tag == "Player" && shoot)
        {
            Player.Instance._State = PlayerState.DIE;
            StartCoroutine(DieScene());
        }
    }
    IEnumerator DieScene()
    {
        yield return new WaitForSeconds(2);
        if (Player.Instance.Dead == false)
        {
            DeathManager.Instance.OnDeathUI(num, sprite, Desc);
        }
    }
    public void ShootFormChange()
    {
        if (shoot)
        {
            shoot = false;
        }
        else
        {
            shoot = true;
        }
    }
    public void PlayerTrace()
    {
        Vector3 target = Player.Instance.transform.position + new Vector3(0, 3, 0);

        transform.DOMove(target, Speed);
        transform.DOLocalRotateQuaternion(Quaternion.Euler(0, 0, 0), Speed);
    }
}
