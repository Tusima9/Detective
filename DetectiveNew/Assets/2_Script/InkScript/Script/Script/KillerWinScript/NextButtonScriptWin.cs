using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NextButtonScriptWin : MonoBehaviour
{
    private InkManagerWin _inkManager;

    
    void Start()
    {
        _inkManager = FindObjectOfType<InkManagerWin>();
        if (_inkManager == null)
        {
            Debug.LogError("ink manager was not found!");
        }
    }
  
    public void OnClick()
    {
        

       // OnButtonPress();
       _inkManager?.DisplayNextLine();
    }
   
}
