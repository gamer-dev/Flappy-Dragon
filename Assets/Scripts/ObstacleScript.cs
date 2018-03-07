using UnityEngine;
using System.Collections;

public class ObstacleScript : MonoBehaviour {

	Rigidbody2D myRigidbody;
	float dragonXposition;
	bool isScoreAdded;
	//float speed = 0.2f;
	
	GameManagerScript gameManager;
	
	void Start()
	{
		myRigidbody = gameObject.GetComponent<Rigidbody2D> ();
		myRigidbody.velocity = new Vector2 (-2.5f,0);
		myRigidbody.transform.Rotate(Vector3.right, Time.deltaTime);
		//myRigidbody.velocity = Vector2.up * speed;
		
		dragonXposition = GameObject.Find("Dragon").transform.position.x;
		
		isScoreAdded = false;
		
		gameManager = GameObject.Find("GameManager").GetComponent<GameManagerScript>();
		
		
	}

	void Update() 
	{
		if(transform.position.x <= dragonXposition) 
		{
			if(!isScoreAdded)
			{
				AddScore();
				isScoreAdded = true;
			}
		}
		
		if (transform.position.x <= -10f)
		{
			Destroy (gameObject);
		}
		
		
	}
	
	void AddScore()
	{
		gameManager.GmAddScore();
	}
	

}
