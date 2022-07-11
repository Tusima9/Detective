using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class OptionPanelFunction : MonoBehaviour
{
    public AudioMixer audioMixer;
    public GameObject Panel;


    public void OpenPanel()
    {
        if (Panel != null)
        {
            Panel.SetActive(true);

        }
        else
        {
            Panel.SetActive(false);
        }
    }
    public void ClosePanel()
    {
        Panel.SetActive(false);
    }

    public void backToMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void Quit()
    {
        Debug.Log("quit");
        Application.Quit();
    }

    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }
    private void FixedUpdate()
    {
        if (Input.GetKeyDown("escape"))
        {
            OpenPanel();
        }
    }
}