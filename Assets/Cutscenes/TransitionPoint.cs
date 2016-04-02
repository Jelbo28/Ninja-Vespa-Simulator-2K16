using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TransitionPoint : MonoBehaviour
{
    public void CutOne()
    {
        SceneManager.LoadScene(1);
    }

    public void CutTwo()
    {
        SceneManager.LoadScene(2);
    }

    public void Disable()
    {
        this.gameObject.SetActive(false);
    }
}
