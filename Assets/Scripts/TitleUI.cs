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
}
