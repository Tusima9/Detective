using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using StatusAll;
using TMPro;

public class ObjectHide : MonoBehaviour, Clickable
{

    // public Sprite selected;
    public TextMeshProUGUI StatusTMP,TurnTMP;
    [SerializeField] private GameObject TurnApp; 

    public void Click()
    {
        Vector3 scale = transform.localScale;
        scale *= 1.5f;
        transform.localScale = scale;
    }

   

    public void Hide()
    {
    GameObject[] objects = GameObject.FindGameObjectsWithTag("UnPlacement");
 
        foreach(GameObject obj in objects)
		{
            obj.SetActive(false);
		}
        FindStatus.GameStatus = 1f;
        StatusTMP.text = "探偵　オブジェクトを開いてください";
    }

    public void Selected(GameObject selected)
    {
        if (GameObject.FindGameObjectWithTag("Placement"))
        {
            if (Input.GetMouseButtonDown(1))
            {
                Debug.Log("is clicking");
                Click();
            }
        }
    }
   // Update is called once per frame
    void Update()
    {
        
    }
}
