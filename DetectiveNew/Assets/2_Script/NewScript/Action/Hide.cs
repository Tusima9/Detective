using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hide : MonoBehaviour
{
    void Start()
    {
        
    }

    public void ActionHide()
    {

        Transform Hierarkhypos = GameObject.Find("Weapon").transform;
        Hierarkhypos.SetSiblingIndex(0);

        GameObject[] unobjects = GameObject.FindGameObjectsWithTag("UnPlacement");

        foreach (GameObject obj in unobjects)
        {
            obj.SetActive(false);
        }


        GameObject[] objects = GameObject.FindGameObjectsWithTag("Placement");

        for (int j = 0; j < objects.Length; j++)
        {
            objects[j].GetComponent<Image>().color = new Color(197/255f,55 / 255f, 0f, 255f);
        }


    }
    
}
