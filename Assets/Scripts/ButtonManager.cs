using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public enum GameState
{
	
	inGame,
	gameOver
	
}


public class ButtonManager : MonoBehaviour {
	
	public static ButtonManager instance;

	public GameState currentGameState = GameState.inGame;
	
	public Canvas inGameCanvas;
	public Canvas gameOverCanvas;
	
	private AudioSource gameOverSound;

	void playGameOver(){
		
		if(DragonScript.instance.isAlive == false)
		{
		gameOverSound.Play(5100);
		}
	}
	
	void Awake()
	{
		instance = this;
	}
	
	void Start()
	{
		gameOverSound = gameObject.GetComponent<AudioSource>();
		StartGame();
	}
	
	//called to start game
	public void StartGame()
	{
		SetGameState(GameState.inGame);
	}
	
	
	//called when player dies
	public void gameOver()
	{
		playGameOver();	
		SetGameState(GameState.gameOver);
		
	}



	//called when player clicks on quit
	public void onQuit()
	{
		Application.Quit();
	}
	
	//calls when player wants to go back to mainmenu
	public void backToMenu()
	{
		SceneManager.LoadScene("MainMenu");
	}
	
	//Called when player wants to play again
	public void reloadLevel()
	{
		//DragonScript.instance.Start();
		 Time.timeScale = 1f;//un-freeze the time
		
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);//Reload the scene
	}
	
	void SetGameState (GameState newGameState)
	{
		
		if(newGameState == GameState.inGame)
		{
			inGameCanvas.enabled = true;
			gameOverCanvas.enabled = false;
			
		}
		
		else if (newGameState == GameState.gameOver)
		{
			inGameCanvas.enabled = false;
			gameOverCanvas.enabled = true;
		}
		
		currentGameState = newGameState;
	}
	


}
