﻿using UnityEngine;
using System.Collections;

public class TransitionPoint : MonoBehaviour
{
    public void CutOne()
    {
		Application.LoadLevel(1);
    }

    public void CutTwo()
    {
        Application.LoadLevel(2);
    }

    public void Disable()
    {
        this.gameObject.SetActive(false);
    }
}
