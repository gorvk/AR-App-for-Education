using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour 
{
	
	public void LoadComputer() // Method to change scene with fadeIn or fadeOut Animation.  
	{
		SceneManager.LoadScene(2); // Load the particular scene.
	}
	public void LoadMech() // Method to change scene with fadeIn or fadeOut Animation.
	{
		SceneManager.LoadScene(3); // Load the particular scene.
	}
	public void LoadCivil() // Method to change scene with fadeIn or fadeOut Animation.
	{
		SceneManager.LoadScene(4); // Load the particular scene.
	}
	public void LoadEtx() // Method to change scene with fadeIn or fadeOut Animation.
	{
		SceneManager.LoadScene(5); // Load the particular scene.
	}
	public void LoadAnatomy() // Method to change scene with fadeIn or fadeOut Animation.
	{
		SceneManager.LoadScene(6); // Load the particular scene.
	}
	public void quitApp() // Method to Exit the application.
	{
		Application.Quit();
	}

}
