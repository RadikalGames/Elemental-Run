using UnityEngine;
using System.Collections;

public class Extras_behaviour_script : MonoBehaviour {

    private float speed;
    public Transform Destruction_point;
	// Use this for initialization
	void Start () {
        speed = Random.Range(4, 7);
        Destruction_point = GameObject.Find("Destruction_point").transform;
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(new Vector3(-speed*Time.deltaTime, 0, 0));
        if (transform.position.x < Destruction_point.position.x)
            gameObject.SetActive(false);
	}
}
