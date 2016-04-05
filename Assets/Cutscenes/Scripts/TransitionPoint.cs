using UnityEngine;
using System.Collections;

public class TransitionPoint : MonoBehaviour
{
	[SerializeField]
	AudioSource[] sounds;
	public AudioSource engine;
	public AudioSource honk;

	void start()
	{
		sounds = GetComponents<AudioSource> ();
		engine = sounds [0];
		honk = sounds [1];
	}

    public void CutOne()
    {
		Application.LoadLevel(1);
    }

    public void CutTwo()
    {
        Application.LoadLevel(2);
    }

    public void CutAudio()
    {
        this.gameObject.GetComponent<AudioSource>().mute = true;
    }

    public void Disable()
    {
        this.gameObject.SetActive(false);
    }

	public void Honk()
	{
		honk.Play ();
	}
}
