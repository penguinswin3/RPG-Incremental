using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEditor;

public class MainMenu : MonoBehaviour {

	public void PlayGame(){
		SceneManager.LoadScene ("MainScene");
	}

	public void ExitGame(){
		Application.Quit();
	}

	public void OptionsMenu(){
		//TODO: Switch to options menu 
		EditorUtility.DisplayDialog("Not yet Implemented", "Options menu in progress", "ok", "ok");
	}
}
