using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Inventory : Singleton<Inventory>
{
    public bool Shoose = false;
    public bool note = false;
    public bool pen = false;
    public bool minem = false;
    public bool among = false;
    public bool portal = false;
    public bool Creeper = false;
    public bool Chicken = false;
    public bool Button = false;
    public int MissingPoster;

    private void Update()
    {
        if (Shoose == true && SceneManager.GetActiveScene().name == "PlaygroundMap")
        {
            foreach (Collider2D obj in Physics2D.OverlapCircleAll(new Vector2(6, -9), 0.4f))
            {
                if (obj.gameObject == Player.Instance.gameObject)
                {
                    if (Player.Instance.Dead == false)
                    {
                        Player.Instance.Dead = true;
                        StartCoroutine(DeathManager.Instance.ShooseDie());
                    }
                }
            }
        }
        if (note == true && pen == true)
        {
            if (Player.Instance.Dead == false) StartCoroutine(DeathManager.Instance.DeathNote());
        }

        if (among == true)
        {
            if (Player.Instance.Dead == false) StartCoroutine(DeathManager.Instance.amongDie());
        }

        if (portal == true)
        {
            if (Player.Instance.Dead == false) StartCoroutine(DeathManager.Instance.portalDie());
        }

        if(Creeper == true)
        {
            if (Player.Instance.Dead == false) StartCoroutine(DeathManager.Instance.CreeperDie());
        }
        if(Chicken == true)
        {
            if (Player.Instance.Dead == false) StartCoroutine(DeathManager.Instance.ChickenDie());
        }
        if (Button == true)
        {
            if (Player.Instance.Dead == false) StartCoroutine(DeathManager.Instance.ButtonDie());
        }
    }
}

