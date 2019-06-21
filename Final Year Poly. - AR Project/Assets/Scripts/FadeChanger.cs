using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeChanger : MonoBehaviour 
{

	public Animator animator;
	private int levelToLoad;
	
	void Update () //It is called once per second.
	{
		if(Input.GetMouseButtonDown(0)) // If left mouse or screen is touched.
		{
			FadeToLevel(1);	// Change to scene no. 1.
		}		
	}
	
	public void FadeToLevel(int levelIndex) // Method to trigger the Animation to be performed.
	{
		levelToLoad=levelIndex;
		animator.SetTrigger("FadeOut"); // Enable the FadeOut Animation.
	}
	
	public void OnFadeComplete() // Method to change scene with fadeIn or fadeOut Animation.
	{
		SceneManager.LoadScene(levelToLoad); // Load the particular scene.
	}
	
}
