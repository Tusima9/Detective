using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StatusChange;

public class AnswerLog : MonoBehaviour
{
    private GameStatus _GameStatus;
    [SerializeField] private GameObject AnswerPanel,Main,Set,Detect;
    [SerializeField] private bool Logcheck;
    void Start()
    {
        _GameStatus = FindObjectOfType<GameStatus>();
        Logcheck = false;
    }

    public void Logcall()
	{
        Logcheck = true;
	}
    

    public void OpenLog()
	{
		if (Logcheck == true)
		{
        AnswerPanel.gameObject.SetActive(false);
        Main.GetComponent<Canvas>().sortingOrder = -3;
        Set.GetComponent<Canvas>().sortingOrder = -3;

		}

        
    }

    public void HideLog()
	{
		if (Logcheck == true)
		{
		    AnswerPanel.gameObject.SetActive(true);

		}
        
	}
}
