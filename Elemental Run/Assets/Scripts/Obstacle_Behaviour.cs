using UnityEngine;
using System.Collections;

public class Obstacle_Behaviour : MonoBehaviour {

    public static bool collided;
    public static int DamageAmt;
	private GameObject g;
	private ScoreManager instance;
	// Use this for initialization
	
	void Start()
	{
		g = GameObject.Find ("ScoreManager");
		instance = g.GetComponent<ScoreManager> ();
	}
	// Update is called once per frame
	void Update () {
	
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name=="Player")
		{	if (Element_Switching.current_element == 1)
				instance.Ihp -= 10f;
			else if (Element_Switching.current_element == 2)
				instance.Ehp -= 10f;

			PlayerController.collided = true;
            CollidedWithPlayer();
            //gameObject.transform.position = new Vector3(transform.position.x, transform.position.y, -1f);
                gameObject.transform.Translate(0, -50f * Time.smoothDeltaTime, 0);
                //col.enabled = false;
            
        }
    }
	private void OnTriggerExit2D(Collider2D collision)
	{
		PlayerController.collided = false;
		gameObject.SetActive (false);
	}
	public static void CollidedWithPlayer()
    {
        collided = true;
        
    }
}
