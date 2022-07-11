using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Uncolor : MonoBehaviour
{
  

    [SerializeField] public GameObject[] Red=new GameObject[32];
    // Start is called before the first frame update
    void Start()
    {
		for (int i = 0; i < 32; i++)
		{
        Red[i].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0.25f); 
		}
    }
    public void Spown()
	{
        for(int j = 0; j < 32; j++)
		{
			if (GameObject.FindGameObjectWithTag("Placement"))
			{
		        Red[j].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
             
            }

          
        }
    }
}
