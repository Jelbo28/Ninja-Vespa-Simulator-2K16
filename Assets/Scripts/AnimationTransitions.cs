using UnityEngine;
using System.Collections;

public class AnimationTransitions : MonoBehaviour
{
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

    public void Play()
    {
        Application.LoadLevel(4);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Disable()
    {
        this.gameObject.SetActive(false);
    }
}
