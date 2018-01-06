using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
    public PlayerController instance;

    private Vector3 lastPlayerPosition;
    private float distance;
	// Use this for initialization
	void Start () {

        lastPlayerPosition = instance.transform.position;
	}
	
	// Update is called once per frame
	void Update () 
    {
        distance = instance.transform.position.x - lastPlayerPosition.x;

        transform.position = new Vector3(transform.position.x + distance, transform.position.y, transform.position.z);

        lastPlayerPosition = instance.transform.position;
	}
}
