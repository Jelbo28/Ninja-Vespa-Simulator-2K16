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

	public void CutThree()	
	{
		Application.LoadLevel(9);
	}

	public void CutFour()
	{
		Application.LoadLevel(10);
	}

    public void Credits()
    {
        Application.LoadLevel(3);
    }

    public void Play()
    {
        Application.LoadLevel(4);
    }

	public void Level()
	{
		Application.LoadLevel(5);
	}

	public void LoadTwo()
	{
		Application.LoadLevel(6);
	}

    public void Quit()
    {
        Application.Quit();
    }

	public void Gameover()
	{
		Application.LoadLevel (11);
	}

	public void LoadFight()
	{
		Application.LoadLevel (7);
	}

    public void Disable()
    {
        this.gameObject.SetActive(false);
    }
}
