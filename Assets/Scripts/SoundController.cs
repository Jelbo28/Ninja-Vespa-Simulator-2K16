using UnityEngine;
using System.Collections;

public class SoundController : MonoBehaviour
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

    public void CutAudio()
    {
        this.gameObject.GetComponent<AudioSource>().enabled = false;
    }

    public void Honk()
    {
        honk.Play();
    }
}
