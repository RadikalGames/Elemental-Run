using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_Behaviour : MonoBehaviour 
{
	private ScoreManager instance;
	private GameObject g;

	// Use this for initialization
	void Start () 
	{
		g = GameObject.Find ("ScoreManager");
		instance = g.GetComponent<ScoreManager> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.name == "Player") 
		{
			instance.Score += 1;
			gameObject.SetActive (false);
		}
	}

	private void OnTriggerExit2D(Collider2D collision)
	{
	}
}
