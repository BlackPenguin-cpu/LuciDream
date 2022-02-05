using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Objects : MonoBehaviour
{
    Outline outline;
    private bool isCliked;
    public bool _isCliked
    {
        get { return isCliked; }
        set
        {
            if (value)
            {
                outline.enabled = true;
            }
            else
            {
                outline.enabled = false;
            }
            isCliked = value;
        }
    }
    private void Start()
    {
        outline = GetComponent<Outline>();
        outline.enabled = false;
    }

    public virtual void OnCliked()
    {
        isCliked = true;
    }
    public abstract void Interaction();
    
}
