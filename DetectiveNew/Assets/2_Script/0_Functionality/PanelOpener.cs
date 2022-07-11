using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using StatusAll;

public class PanelOpener : MonoBehaviour
{
    public AudioMixer audioMixer;
    public GameObject Panel;
    public GameObject clear; 
    public GameObject inv;
    public GameObject storyPanel;
  

    public void menuPanel()
    {
        if (Panel!= null)
        {
            Panel.SetActive(true);

        }

    }

    public void InvetigatePanel()
    {
        if (inv != null)
        {
            Debug.Log("‚±‚±");
            inv.SetActive(true);
            clear.SetActive(true);
        }

    }

    public void StoryPanel()
    {
        if (storyPanel != null)
        {
            storyPanel.SetActive(true);

        }

    }

    public void ClosePanel()
    {
        Panel.SetActive(false);
        inv.SetActive(false);
        storyPanel.SetActive(false);
        clear.SetActive(false);
    }

    public void backToMenu()
    {
        FindStatus.GameStatus=0;
        SceneManager.LoadScene(0);
    }
    public void Quit()
    {
        Debug.Log("quit");
        Application.Quit();
    }

    private void FixedUpdate()
    {
        if (Input.GetKeyDown("escape"))
        {
            menuPanel();
        }
    }

    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }

}
