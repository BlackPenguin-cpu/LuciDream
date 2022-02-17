using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    bool Shoose = false;
    public bool note = false;
    public bool pen = false;
    public bool minem = false;
    public bool among = false;
    public bool portal = false;

    private void Update()
    {
        if (Shoose == true)
        {
            if (Player.Instance.transform.position.x <= 7
                && Player.Instance.transform.position.x >= 5
                && Player.Instance.transform.position.y >= -8
                && Player.Instance.transform.position.y <= -10)
            {
                if (Player.Instance.Dead == false) StartCoroutine(DeathManager.Instance.ShooseDie());
            }
        }

        if(note == true && pen == true)
        {
            if (Player.Instance.Dead == false) StartCoroutine(DeathManager.Instance.DeathNote());
        }

        if(among == true)
        {
            if (Player.Instance.Dead == false) StartCoroutine(DeathManager.Instance.amongDie());
        }

        if(portal == true)
        {
            if (Player.Instance.Dead == false) StartCoroutine(DeathManager.Instance.amongDie());
        }
    }
}
