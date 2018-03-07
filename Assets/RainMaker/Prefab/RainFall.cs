using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RainFall : MonoBehaviour {

	public Transform rainHolder;
	public GameObject rainPrefab; 
	float waitTime, rainTime;
	

	void Awake() 
	{ waitTime = Random.Range(1.0f, 4.0f);
		rainTime = Random.Range(5.5f, 9.5f);
	//StartCoroutine(showRain());
	}
	

	IEnumerator showRain() 
	{ 
	
	while (true)
	{
	yield return new WaitForSeconds(waitTime);
        GameObject g = (GameObject) Instantiate(rainPrefab, rainHolder);
		g.transform.position = new Vector2(0f, Random.Range(0.0f, 3.5f));
		g.transform.rotation = Quaternion.identity;
		g.SetActive(true);
		
		if (SceneManager.GetActiveScene().name == "playScene")
		{
		yield return new WaitForSeconds(rainTime);
		Destroy(g);
		}
	}	
   
	/* REMOVE ME
	yield return new WaitForSeconds(waitTime); 
	
	//ALTERNATIVE CODE 1:
	//Instantiate(rainPrefab, new Vector2 (0f,Random.Range(0.0f, 3.5f)) , Quaternion.identity);
	//rainPrefab.SetActive(true);
	//ALTERNATIVE CODE 1 END
	
	//ALTERNATIVE CODE 2 START:
	
	
	GameObject g = (GameObject) Instantiate(rainPrefab);
	g.transform.position = new Vector2(0f, Random.Range(0.0f, 3.5f));
	g.transform.rotation = Quaternion.identity;
	g.SetActive(true);
	//yield return new WaitForSeconds(waitTime);
	//g.SetActive(false);
	//ALTERNATIVE CODE 2 END
 remove me   e mem me me me m */
	}
	
	/*  void RemoveRain()
	{
		foreach(Transform t in rainHolder.GetComponentsInChildren<Transform>())
		
		if(t != rainHolder)
			Destroy(t.gameObject);
		
	} */
	
	void Start()
	{ 
	
	StartCoroutine(showRain()); 
	//RemoveRain();
	//StopCoroutine("showRain");
	//InvokeRepeating ("StartCoroutine(showRain)", waitTime, 2.0f); 
	
	}
}
