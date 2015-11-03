using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

	public void Awake(){
	
	}

	public void StartButtonClicked (){
	
		Application.LoadLevel (1);
		Debug.Log ("Game started.");
	}
	
	public void QuitButtonClicked (){
		//If we are running in a standalone build of the game
		#if UNITY_STANDALONE
		//Quit the application
		Application.Quit ();
		Debug.Log ("Game quit");
		#endif
		
		//If we are running in the editor
		#if UNITY_EDITOR
		//Stop playing the scene
		UnityEditor.EditorApplication.isPlaying = false;
		Debug.Log ("Game quit");
		#endif
	}
}
