using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour {

	public int myScore;
	public Text myScoreGUI, myScoreGUI2;
	
	public float waitTime, intervalTime; //variables to control the spawn time
	
	public Transform bottomObstacle, topObstacle; //variables to reference the prefabs we have in our scene, top and bottom
	
	private AudioSource audioSource;
	
	public void GmAddScore()
	{
		this.myScore++;
		myScoreGUI.text = myScore.ToString();
		myScoreGUI2.text = myScore.ToString();
		audioSource.Play();
	}
	
	void ObstacleSpawner() //function to spawn the obstacles
	{
		int rand = Random.Range (0,2);
		// Take a random number,either 0 or 1 to decide whether create top or bottom obstacle, 0=bottom, 1=top
		
		//Now, define the constraints where the top and bottom obstacles can be generated, define their min and max y axes 
		float topObstacleMinY = 2f; //1f;
		float topObstacleMaxY = 6f; // 8f;
		float bottomObstacleMinY = -6f;  //8f;
		float bottomObstacleMaxY = -2f;   //-1f;
		
		switch(rand)
		{
			case 0://generate bottom obstacle
				
				Instantiate(bottomObstacle, new Vector2 (9f,Random.Range(bottomObstacleMinY, bottomObstacleMaxY)) , Quaternion.identity);
				
				//Instantiate is a prebuilt function in unity to generate instances of prefabs
				//It takes in 3 parameters:
				//a.Prefab reference : which prefab to generate, in our case, the topObstacle and bottomObstacle
				//b.Position to generate: Where should it generate the prefab on the screen? We set it to x=9f and Y in a Random range of the min and max values.
				//c.Rotation: We let Quaternion.identity handle it in this case.
				
				break;
				
			case 1://generate top obstacle
			
				Instantiate(topObstacle, new Vector2 (9f,Random.Range(topObstacleMinY, topObstacleMaxY)) , Quaternion.identity);
				
				
				break;
		
				
		}
	
	}
	
	
	
	
	void Start()
	{
		myScore = 0;
		
		myScoreGUI = GameObject.Find ("Score").GetComponent<Text> ();
		myScoreGUI2 = GameObject.Find ("FinalScore").GetComponent<Text> ();

		
		InvokeRepeating ("ObstacleSpawner", waitTime, intervalTime); 
		//NOTES:
		//used to repeatedly call a specified function.
		//Has 3 parameters:
		//a.Function Name: Function I want to call
		//b.How long to wait to start calling the function repeatedly
		//c.Specify the interval between each calls, in our case, THIS determines the distance between the two obstacles (horizantal distance, how far away they are)
		
		audioSource = gameObject.GetComponent<AudioSource> ();
	}



	
	
}





