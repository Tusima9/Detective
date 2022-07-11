using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public static scenefader fader;
public void PlayGame()
    {
		if (SceneManager.GetActiveScene().buildIndex == 4|| SceneManager.GetActiveScene().buildIndex == 3)
		{
            SceneManager.LoadScene(0);
		}
		else
		{
            //fader.fadeToNextScene();
            //fader.fadeComplete();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		}

    }   

    public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();

    }

}
