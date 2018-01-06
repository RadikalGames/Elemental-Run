using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ObjectPooler : MonoBehaviour {
    public int pooledAmount;
    public GameObject IcePlat;
    public GameObject EarthPlat;
    public GameObject[] IceExtras = new GameObject[6];
    public GameObject[] EarthExtras = new GameObject[4];
    public GameObject[] IceObs = new GameObject[4];
	public GameObject[] EarthObs = new GameObject[2];
	List<GameObject> PooledIcePlats;
    List<GameObject> PooledEarthPlats;
    List<GameObject> PooledIceExtras;
    List<GameObject> PooledEarthExtras;
    List<GameObject> PooledIceObstacles;
	List<GameObject> PooledEarthObstacles;

	// Use this for initialization
	void Start () {
        PooledIcePlats = new List<GameObject>();
        PooledEarthPlats = new List<GameObject>();
        PooledIceExtras = new List<GameObject>();
        PooledEarthExtras = new List<GameObject>();
        PooledIceObstacles = new List<GameObject>();
		PooledEarthObstacles = new List<GameObject>();
        for(int i=0;i<pooledAmount;++i)
        {
            GameObject ob =(GameObject)Instantiate(IcePlat);
            ob.SetActive(false);
            PooledIcePlats.Add(ob);
        }
        for (int i = 0; i < pooledAmount; ++i)
        {
            GameObject ob = (GameObject)Instantiate(EarthPlat);
            ob.SetActive(false);
            PooledEarthPlats.Add(ob);
        }
        for(int i=0;i<6;i++)
        {
            GameObject ob = (GameObject)Instantiate(IceExtras[Random.Range(0, 5)]);
            ob.SetActive(false);
            PooledIceExtras.Add(ob);
        }
        for (int i = 0; i < 5; i++)
        {
            GameObject ob = (GameObject)Instantiate(EarthExtras[Random.Range(0, 4)]);
            ob.SetActive(false);
            PooledEarthExtras.Add(ob);
        }
        for (int i = 0; i < 3; i++)
        {
            GameObject ob = (GameObject)Instantiate(IceObs[i]);
            ob.SetActive(false);
            PooledIceObstacles.Add(ob);
        }
		for (int i = 0; i < 2; i++)
		{
			GameObject ob = (GameObject)Instantiate(EarthObs[i]);
			ob.SetActive(false);
			PooledEarthObstacles.Add(ob);
		}
	}
	
	// Update is called once per frame
	
    public GameObject GetPooledIcePlat()
    {
            for(int i=0;i<PooledIcePlats.Count;++i)
            {
                if (!PooledIcePlats[i].activeInHierarchy)
                    return PooledIcePlats[i];
            }
            GameObject ob = (GameObject)Instantiate(IcePlat);
            ob.SetActive(false);
            PooledIcePlats.Add(ob);

            return ob;
    }
    public GameObject GetPooledEarthPlat()
    {
        for (int i = 0; i < PooledEarthPlats.Count; ++i)
        {
            if (!PooledEarthPlats[i].activeInHierarchy)
                return PooledEarthPlats[i];
        }
        GameObject ob = (GameObject)Instantiate(EarthPlat);
        ob.SetActive(false);
        PooledEarthPlats.Add(ob);

        return ob;
    }
    public GameObject GetPooledIceExtra()
    {
        for (int i = 0; i < PooledIceExtras.Count; ++i)
        {
            if (!PooledIceExtras[i].activeInHierarchy)
                return PooledIceExtras[i];
        }
        GameObject ob = (GameObject)Instantiate(IceExtras[Random.Range(0,5)]);
        ob.SetActive(false);
        PooledIceExtras.Add(ob);

        return ob;
    }
    public GameObject GetPooledEarthExtra()
    {
        for (int i = 0; i < PooledEarthExtras.Count; ++i)
        {
            if (!PooledEarthExtras[i].activeInHierarchy)
                return PooledEarthExtras[i];
        }
        GameObject ob = (GameObject)Instantiate(EarthExtras[Random.Range(0, 4)]);
        ob.SetActive(false);
        PooledEarthExtras.Add(ob);

        return ob;
    }
    public GameObject GetPooledIceObs()
    {
        for (int i = 0; i < PooledIceObstacles.Count; ++i)
        {
            if (!PooledIceObstacles[i].activeInHierarchy)
                return PooledIceObstacles[i];
        }
        GameObject ob = (GameObject)Instantiate(IceObs[Random.Range(0,3)]);
        ob.SetActive(false);
        PooledIceObstacles.Add(ob);

        return ob;
    }
	public GameObject GetPooledEarthObs()
	{
		for (int i = 0; i < PooledEarthObstacles.Count; ++i)
		{
			if (!PooledEarthObstacles[i].activeInHierarchy)
				return PooledEarthObstacles[i];
		}
		GameObject ob = (GameObject)Instantiate(EarthObs[Random.Range(0,1)]);
		ob.SetActive(false);
		PooledEarthObstacles.Add(ob);

		return ob;
	}
}
