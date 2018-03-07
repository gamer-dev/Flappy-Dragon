using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ButtonClicks : MonoBehaviour {

	//public AudioSource clickSound;
	

	public void onPlay()
	{
		
		//clickSound = gameObject.GetComponent<AudioSource> ();
		//audioSource.PlayOneShot(clickSound);
		
		SceneManager.LoadScene("playScene");
	}
	
	public void onQuit()
	{
		//clickSound = gameObject.GetComponent<AudioSource> ();
	
		Application.Quit();
	}
}
