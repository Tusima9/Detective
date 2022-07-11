using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenefader : MonoBehaviour
{
    public Animator animator;
    MainMenu menu;
    private int loadtoLevel;

    private void Start()
    {
        menu = FindObjectOfType<MainMenu>();
    }

    public void fadeToNextScene()
    {
        if(SceneManager.GetActiveScene().buildIndex==3|| SceneManager.GetActiveScene().buildIndex == 4)
		{
            fadeToScene(0);
		}
		else
		{

        fadeToScene(SceneManager.GetActiveScene().buildIndex + 1);
        
        }
    }

    public void fadeToScene(int LevelIndex)
    {
        loadtoLevel = LevelIndex;
        animator.SetTrigger("FadeOut");
        Invoke(nameof(fadeComplete),1.7f);
    }

    public void fadeComplete()
    {
        SceneManager.LoadScene(loadtoLevel);
    }
}
