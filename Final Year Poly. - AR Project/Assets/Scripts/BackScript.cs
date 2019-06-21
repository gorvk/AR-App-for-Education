using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BackScript : MonoBehaviour 
{

	public void LoadMain() // Method to change scene with fadeIn or fadeOut Animation.
	{
		SceneManager.LoadScene(1); // Load the particular scene.
	}

}
