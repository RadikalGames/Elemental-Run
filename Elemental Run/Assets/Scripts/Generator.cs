using UnityEngine;
using System.Collections;

public class Generator : MonoBehaviour {

	//public GameObject Ice_platform;
    public GameObject PlayerRef;
    public Transform generationpoint;
    Vector3 currentPos;
    void Start()
    {
      //currentPos = new Vector3(PlayerRef.transform.position.x + Random.Range(10, 15), -2.6f, 0f);
    }

    public ObjectPooler instance;
	// Use this for initialization
	void IceObstacleGenerator()
    {
       
        //Vector3 newPos = new Vector3(currentPos.x+Random.Range(8f,10f),-2.6f,0f);
       // if((Random.Range(0,10)%7==0))
		//{	
			print ("reached");
            GameObject newIceObs = instance.GetPooledIceObs();
            
			switch (newIceObs.name) 
			{
			case "SnowMan":				
				newIceObs.transform.position = new Vector3 (PlayerRef.transform.position.x+Random.Range(5f,10f), -2.63f, transform.position.z);
					break;
			case "Crystal":
				newIceObs.transform.position = new Vector3 (PlayerRef.transform.position.x+Random.Range(5f,10f), -2.63f, transform.position.z);
					break;
			case "Stone":
				newIceObs.transform.position = new Vector3 (PlayerRef.transform.position.x+Random.Range(5f,10f), 3f, transform.position.z);
					break;
			default:
				print ("default");
				break;
			}
			newIceObs.SetActive (true);
			newIceObs.transform.rotation = transform.rotation;
        //}
		//currentPos = PlayerRef.transform.position;


    }
	void Update()
    {
        if (transform.position.x < generationpoint.position.x)
        {
            transform.position = new Vector3(transform.position.x + 6.55f, -3.0f, transform.position.z);
            GameObject newIcePlat = instance.GetPooledIcePlat();
            GameObject newEarthPlat = instance.GetPooledEarthPlat();
            GameObject newIceExtra = instance.GetPooledIceExtra();
            GameObject newEarthExtra = instance.GetPooledEarthExtra();
			GameObject newIceObs = instance.GetPooledIceObs ();
			GameObject newEarthObs = instance.GetPooledEarthObs();
            newIceExtra.transform.position = new Vector3(transform.position.x + Random.Range(7, 15), -1.97f, 0.25f);
            newIceExtra.transform.rotation = transform.rotation;
            newEarthExtra.transform.position = new Vector3(transform.position.x + Random.Range(7, 15), 8.5f, 0.25f);
            newEarthExtra.transform.rotation = transform.rotation;
            newEarthPlat.transform.position = new Vector3(transform.position.x-8.55f , 7.8f, transform.position.z);

            newEarthPlat.transform.rotation = transform.rotation;
            newIcePlat.transform.position = transform.position;
            newIcePlat.transform.rotation = transform.rotation;

            newIcePlat.SetActive(true);
            newEarthPlat.SetActive(true);
            newIceExtra.SetActive(true);
            newEarthExtra.SetActive(true);

			if(Random.Range(1,10)%7==0)
			{	print ("lol");
				newIceObs.transform.position = new Vector3 (transform.position.x + Random.Range (8f, 10f), -2.63f, transform.position.z);
				newIceObs.transform.rotation = transform.rotation;
				newIceObs.SetActive (true);
			}
			if(Random.Range(1,10)%7==0||Random.Range(1,10)%5==0)
			{	print ("lol");
				newEarthObs.transform.position = new Vector3 (transform.position.x + Random.Range (8f, 10f), 7.8f, transform.position.z);
				newEarthObs.transform.rotation = transform.rotation;
				newEarthObs.SetActive (true);
			}
			/*if(newIceObs.name=="Crystal")
			//newIceObs.transform.position = new Vector3 (transform.position.x + Random.Range (8f, 10f), -2.63f, transform.position.z);
			//if(newIceObs.name=="Stone")
			//	newIceObs.transform.position = new Vector3 (transform.position.x + Random.Range (8f, 10f), -2.63f, transform.position.z);
			//if(newIceObs.name=="SnowMan")
			//	newIceObs.transform.position = new Vector3 (transform.position.x + Random.Range (8f, 10f), -2.63f, transform.position.z);
			//newIceObs.transform.rotation = transform.rotation;*/
			//newIceObs.SetActive (true);
            
        }
    }
	
}

