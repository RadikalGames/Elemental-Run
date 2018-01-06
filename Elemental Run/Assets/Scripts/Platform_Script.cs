using UnityEngine;
using System.Collections;

public class Platform_Script : MonoBehaviour {
    public GameObject Destruction_point;
	// Use this for initialization
	void Start () {
        Destruction_point = GameObject.Find("Destruction_point");
	}
	
	// Update is called once per frame
	void Update () {
        if (this.transform.position.x < Destruction_point.transform.position.x)
            gameObject.SetActive(false);    
	}
}
