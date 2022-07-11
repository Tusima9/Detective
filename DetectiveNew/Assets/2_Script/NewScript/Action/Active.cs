using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using handle;
using StatusChange;

public class Active : MonoBehaviour
{
    public GameObject objHandle,Panel;
    private GameStatus _GameStatus;
    void Start()
    {
        _GameStatus = FindObjectOfType<GameStatus>();
    }

    public void HanActive()
    {
        objHandle = Handle.Activehandle;
        objHandle.gameObject.SetActive(false);
        _GameStatus.StatusNum = 2;
    }

    public void Activefalse()
	{
        Panel.gameObject.SetActive(false); 
	}

}
