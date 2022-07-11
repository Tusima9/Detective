using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NextButtonScriptDefeat : MonoBehaviour
{
    private InkManagerDefeat _inkManager;

    
    void Start()
    {
        _inkManager = FindObjectOfType<InkManagerDefeat>();
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
