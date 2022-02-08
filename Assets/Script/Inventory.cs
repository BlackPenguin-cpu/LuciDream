using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    bool Shoose = false;

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
    }
}
