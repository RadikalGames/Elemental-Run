using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour {

	public Text ScoreText;
	public Text HscoreText;
	public Text EText;
	public Text IText;
	public bool GameOver;
	public float pointsPerSecond;
	public float Score;
	private float HScore;

	public float Ehp;
	public float Ihp;
	public GameObject iceProgressBar, earthProgressBar;
	public  bool scoreIncreasing;
	// Use this for initialization
	void Start () {
		HScore = 30f;
		Ehp = 100f;
		Ihp = 100f;
		scoreIncreasing = true;
	}
	
	// Update is called once per frame
	void Update () 
	{
//		if (IceBG.activeSelf) 
//		{
//			iceProgressBar.GetComponent<Image> ().fillAmount += Time.deltaTime * 0.02f;
//			earthProgressBar.GetComponent<Image> ().fillAmount -= Time.deltaTime  * 0.01f;
//		}
//		else if (EarthBG.activeSelf) 
//		{
//			iceProgressBar.GetComponent<Image> ().fillAmount -= Time.deltaTime * 0.01f;
//			earthProgressBar.GetComponent<Image> ().fillAmount += Time.deltaTime * 0.02f;
//		}
		if (scoreIncreasing) 
		{
			Score += pointsPerSecond * Time.deltaTime;

			if (Element_Switching.current_element == 1)
			{
				Ehp -= Time.deltaTime;
				if (Ihp < 100)
					Ihp += 0.5f * Time.deltaTime;
			} 
			else 
			{
				Ihp -= Time.deltaTime;
				if (Ehp < 100)
					Ehp += 0.5f * Time.deltaTime;
			}
		}	
		if (Score > HScore) 
		{
			HScore = Score;
			PlayerPrefs.SetFloat ("HS", HScore);
		}
		/*if (Obstacle_Behaviour.collided) 
		{
			if(Element_Switching.current_element==1)
				Ihp-=10f;
			else
				Ehp-=10f;
		}*/
		if (Ehp <= 0 || Ihp <= 0)
			GameOver = true;
		
		ScoreText.text = "S c o r e : " + Mathf.Round (Score);
		HscoreText.text = "H i g h s c o r e : " + Mathf.Round (HScore);
		EText.text = "EarthHP : " + Mathf.Round (Ehp);
		IText.text = "Ice HP : " + Mathf.Round (Ihp);
		iceProgressBar.GetComponent<Image> ().fillAmount = Ihp / 100f;
		earthProgressBar.GetComponent<Image> ().fillAmount = Ehp / 100f;
	}
}
