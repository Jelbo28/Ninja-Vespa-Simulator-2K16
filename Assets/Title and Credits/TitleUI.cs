using UnityEngine;
using System.Collections;

public class TitleUI : MonoBehaviour
{
	public void Play()
	{
		//Debug.Log("Play");
		Application.LoadLevel(1);
	}
	
	public void Quit()
	{
		//Debug.Log("Quit");
		Application.Quit();
	}

	public void Credits()
	{
		Application.LoadLevel (2);
	}

	public void Menu()
	{
		Application.LoadLevel (0);
	}
}
