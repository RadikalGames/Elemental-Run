using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallex : MonoBehaviour {

	public float scrollSpeed;
	private Vector2 savedOffset;

	void Start () {
		savedOffset = GetComponent<Renderer>().sharedMaterial.GetTextureOffset ("_MainTex");
	}

	void Update () 
	{
//		float x = Mathf.Repeat (1, Time.time * scrollSpeed);
		Vector2 offset = new Vector2 (Time.time * scrollSpeed, savedOffset.y);
		GetComponent<Renderer>().sharedMaterial.SetTextureOffset ("_MainTex", offset);
	}

//	void OnDisable () {
//		GetComponent<Renderer>().sharedMaterial.SetTextureOffset ("_MainTex", savedOffset);
//	}
}
