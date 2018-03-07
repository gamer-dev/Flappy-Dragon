using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BackgroundChanger : MonoBehaviour {
	
	 SpriteRenderer image;


	// Use this for initialization
	void Start () {

	
		image = GetComponent<SpriteRenderer>();

		
	}
	
	
	
	// Update is called once per frame
	void Update () {
		
		
		if(DragonScript.instance.isAlive == false)
		{
			
			if(gameObject.tag == "mainbg")
				
			{
		
			
			Color c = image.color;
			//c.a = -5;
			c.r = 128.0f;
			c.g = 0.0f;
			c.b= 128.0f;
			c.a= 0.3f;
			image.color = c;
			
		
			
		}
		
		else if(gameObject.tag == "rightbg")
				
			{
				
			
			Debug.Log("U DED!");
			
			Color c = image.color;
			//c.a = -5;
			c.r = 255.0f;
			c.g = 255.0f;
			c.b= 0.0f;
			c.a= 0.5f;
			image.color = c;
			
		
			
		}
		
		
		else if(gameObject.tag == "leftbg")
				
			{
				
			
			Debug.Log("U DED!");
			
			Color c = image.color;
			//c.a = -5;
			c.r = 255.0f;
			c.g = 255.0f;
			c.b= 0.0f;
			c.a= 0.5f;
			image.color = c;
		
			
		}
		
		
		
		
		
		}
	
	}
}
