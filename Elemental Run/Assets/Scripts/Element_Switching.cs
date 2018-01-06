using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Element_Switching : MonoBehaviour {

	// Use this for initialization
    public static int current_element=1;
    private Camera mCamera;
	public GameObject IceBG;
	public GameObject EarthBG;
    public PlayerController Instance;
	private float Cooldown;
    void Awake()
    {
        mCamera = Camera.main;
		Cooldown = 6;
    }
	void Update ()
	{
		Cooldown -= Time.deltaTime;
	}

    public void GoUp()
	{	
		if (Cooldown<=0 && current_element == 1)
        {
            mCamera.transform.position = mCamera.transform.position + new Vector3(0f, 10.5f, 0f);
            gameObject.transform.position = transform.position + new Vector3(0f, 11f, 0f);
        
        Instance.Switch();
        current_element = 2;
        IceBG.SetActive(false);
        EarthBG.SetActive(true);
		}
    }
    public void GoDown()
    {	
        if (gameObject.transform.position.y > 5 && current_element == 2)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, -0.1f, gameObject.transform.position.z);
            mCamera.transform.position = mCamera.transform.position + new Vector3(0f, -10.5f, 0f);
        }
        Instance.Switch();
        IceBG.SetActive(true);
        EarthBG.SetActive(false);
        current_element = 1;
        
    }

}
