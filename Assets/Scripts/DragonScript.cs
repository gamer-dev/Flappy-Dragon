using UnityEngine;
using System.Collections;

public class DragonScript : MonoBehaviour {
	 
	private Rigidbody2D myRigidBody;
	private Animator myAnimator;
	private float jumpForce;
	public bool isAlive;
	private AudioSource deathSound;
	public AudioSource jumpSound;
	
	public static DragonScript instance;
	
	void Awake()
	{
		instance = this;
	}
	
	void Flap()
	{
		//float xPos = transform.position.x;
		//xPos = xPos + 1;
		myRigidBody.velocity = new Vector2 (0, jumpForce);
		myAnimator.SetTrigger("Flap");
	}
	
	void OnCollisionEnter2D(Collision2D target)
	{
		if(target.gameObject.tag == "Obstacles")
		{
			
			isAlive = false;
			deathSound.Play();
			Time.timeScale = 0f;
			ButtonManager.instance.gameOver();

			
		}
	}
	
	void CheckIfDragonVisibleOnScreen() 
	{
		if(Mathf.Abs(gameObject.transform.position.y) > 5.3f)
		{
			isAlive = false;
			deathSound.Play();
			Time.timeScale = 0f;
			ButtonManager.instance.gameOver();
		}
	}
	
	
	//void Awake(){
	//	instance = this;
	//}
	
	
	
	
	
	public void Start ()
	{
		ButtonManager.instance.StartGame();
		isAlive = true;
		
		myRigidBody = gameObject.GetComponent<Rigidbody2D>();
		myAnimator = gameObject.GetComponent<Animator> ();
		
		jumpForce = 10f;
		myRigidBody.gravityScale = 5f;
		
		deathSound = gameObject.GetComponent<AudioSource> ();
		
		
		
	}
	
	
	void Update()
	{
		
		if (isAlive){
			
			if(Input.GetMouseButton(0))
			{ 
				Flap();
				jumpSound.Play();
			}
			
			CheckIfDragonVisibleOnScreen();
			
		}
		
		
	}
	
	
	
	
	
	
	
	
	
	

}
