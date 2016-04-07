﻿using UnityEngine;
using System.Collections;

public class TransitionPoint : MonoBehaviour
{
    [SerializeField]
    AudioSource[] sounds;
    public AudioSource engine;
    public AudioSource honk;

    void start()
    {
        sounds = GetComponents<AudioSource>();
        engine = sounds[0];
        honk = sounds[1];
    }

    public void CutOne()
    {
		Application.LoadLevel(1);
    }

    public void CutTwo()
    {
        Application.LoadLevel(2);
    }

    public void Credits()
    {
        Application.LoadLevel(3);
    }

    public void Disable()
    {
        this.gameObject.SetActive(false);
    }

    public void CutAudio()
    {
        this.gameObject.GetComponent<AudioSource>().enabled = false;
    }

    public void Honk()
    {
        honk.Play();
    }
}
