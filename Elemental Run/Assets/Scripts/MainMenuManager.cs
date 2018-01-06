using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour {

	public GameObject MainMenu;
	public GameObject OptionsMenu;
	public GameObject HighMenu;
	public GameObject SoundObj;
	private float HS;
	public Text HSText;
	public bool SoundOn;

	void Start()
	{
		SoundOn = true;
		HS = PlayerPrefs.GetFloat ("HS", HS);
		HSText.text = "Your HighScore is " + Mathf.Round (HS);
	}
	// Use this for initialization
	public void PlayGame()
	{
		SceneManager.LoadScene ("Test");
	}
	public void OptionsClick()
	{
		MainMenu.SetActive (false);
		OptionsMenu.SetActive (true);
	}
	public void HighClick()
	{
		MainMenu.SetActive (false);
		HighMenu.SetActive (true);
	}
	public void BackToMain()
	{
		HighMenu.SetActive (false);
		OptionsMenu.SetActive (false);
		MainMenu.SetActive (true);
	}
	public void Quit()
	{
		Application.Quit ();
	}
	public void SoundClick()
	{
		if (SoundOn) {
			SoundOn = false;
			SoundObj.SetActive (false);
		} 
		else 
		{
			SoundOn = true;
			SoundObj.SetActive (true);
		}
	}


}
