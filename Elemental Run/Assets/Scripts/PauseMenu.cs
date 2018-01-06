using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour {

	public string MainMenuLevel;
	public GameObject PMenu;
	public GameObject ScoreMenu;

	public	 void PauseGame()
	{
		Time.timeScale = 0f;
		PMenu.SetActive (true);
		ScoreMenu.SetActive (false);

	}
	public void ResumeGame()
	{	Time.timeScale = 1f;	
		ScoreMenu.SetActive (true);
		PMenu.SetActive (false);
		
	}
	public void RestartGame()
	{	Time.timeScale = 1f;
		PMenu.SetActive (false);

		FindObjectOfType<GameManager> ().Reset ();
	}
	public void QuitToMain()
	{
		Application.LoadLevel(MainMenuLevel);
	}
}
