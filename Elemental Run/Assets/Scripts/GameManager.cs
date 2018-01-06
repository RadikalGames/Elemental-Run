using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public Transform platformGenerator;
	private Vector3  GenStartPos;
	private Platform_Script[] platformList;
	public PlayerController Instance;
	public static bool GameOver;
	//public  float CoolDown_Count;

	public PlayerController PlayerRef;
	public ScoreManager ScoreRef;
	private Vector3 PlayerStartPoint;
	public GameObject ScoreMenu;
	public GameObject PauseButton;
	public Text FinalScore;

	public	DeathMenu DMenu;

	// Use this for initialization
	void Start () 
	{	Time.timeScale = 1f;
		//CoolDown_Count = 6f;
		GenStartPos = platformGenerator.position;
		PlayerStartPoint = PlayerRef.transform.position;
		GameOver = false;	
		PauseButton.SetActive (true);
		ScoreMenu.SetActive (true);
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (ScoreRef.GameOver == true)
			RestartGame ();
		
		//CoolDown_Count -= Time.deltaTime;
	}
	public void RestartGame()
	{	
		Time.timeScale = 0f;
		DMenu.gameObject.SetActive (true);
		ScoreMenu.SetActive (false);
		PauseButton.SetActive (false);
		ScoreRef.scoreIncreasing = false;
		FinalScore.text = "Your Score: " + Mathf.Round (ScoreRef.Score);
		//PlayerRef.gameObject.SetActive (false);
		//StartCoroutine ("ResetCo");
	}
	public void Reset()
	{	DMenu.gameObject.SetActive(false);
		Time.timeScale = 1f;
		/*platformList = FindObjectsOfType<Platform_Script> ();
		for (int i = 0; i < platformList.Length; i++) 
		{
			platformList [i].gameObject.SetActive (false);
		}
		PlayerRef.transform.position = PlayerStartPoint;
		ScoreRef.GameOver = false;
		ScoreRef.scoreIncreasing = true;
		ScoreRef.Score = 0f;
		ScoreRef.Ehp = 100f;
		ScoreRef.Ihp = 100f;
		platformGenerator.position = GenStartPos;
		//PlayerRef.gameObject.SetActive (true);
		Instance.moveSpeed = 5f;*/
		SceneManager.LoadScene (1);

	}
	/*public IEnumerator ResetCo()
	{	PlayerRef.gameObject.SetActive (false);
		yield return new WaitForSeconds (0.5f);
		platformList = FindObjectsOfType<Platform_Script> ();
		for (int i = 0; i < platformList.Length; i++) 
		{
			platformList [i].gameObject.SetActive (false);
		}
		PlayerRef.transform.position = PlayerStartPoint;
		platformGenerator.position = GenStartPos;
		PlayerRef.gameObject.SetActive (true);

	}*/
}
