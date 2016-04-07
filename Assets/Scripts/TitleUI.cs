using UnityEngine;
using System.Collections;

public class TitleUI : MonoBehaviour
{
	public void Play()
	{
		//Debug.Log("Play");
		Application.LoadLevel(4);
	}
	
	public void Quit()
	{
		//Debug.Log("Quit");
		Application.Quit();
	}

	public void Credits()
	{
		Application.LoadLevel (3);
	}

	public void Menu()
	{
		Application.LoadLevel (2);
	}
}
