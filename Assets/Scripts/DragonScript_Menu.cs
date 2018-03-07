using UnityEngine;
using System.Collections;

public class DragonScript_Menu : MonoBehaviour {
	 
	private Rigidbody2D myRigidBody;
	private Animator myAnimator;
	
	
	void Start ()
	{
		
		myRigidBody = gameObject.GetComponent<Rigidbody2D>();
		myAnimator = gameObject.GetComponent<Animator> ();
		myRigidBody.isKinematic = true;
	
		
		
		
		
	}
	
	
	void Update()
	{
		
		myAnimator.SetTrigger("Flap");
		
		
	}
	
	
	
	
	
	
	
	
	
	

}
