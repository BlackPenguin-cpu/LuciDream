using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public Animator anim;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void Shake()
    {
        anim.SetBool("isShakeing", true);
    }
    public void PlayerOff()
    {
        Player.Instance.gameObject.layer = 8;
    }
}
