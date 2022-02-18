using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Objects : MonoBehaviour
{
    private bool isOutLine;
    public bool isClicked;
    SpriteRenderer spriteRenderer;
    public bool _isOutLine
    {
        get { return isOutLine; }
        set
        {
            if (value)
            {
                spriteRenderer.material = Resources.Load<Material>("OutLine");
            }
            else
            {
                spriteRenderer.material = Resources.Load<Material>("Default");
            }
            isOutLine = value;
        }
    }
    protected virtual void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    protected void OnMouseEnter()
    {
        _isOutLine = true;
    }
    protected void OnMouseExit()
    {
        if (isClicked == false)
        {
            _isOutLine = false;
        }
    }

    public virtual void OnCliked()
    {
        _isOutLine = true;
        isClicked = true;
    }
    public virtual void Interaction()
    {
        _isOutLine = false;
        isClicked = false;
    }

}
