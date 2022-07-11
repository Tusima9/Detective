using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Place : MonoBehaviour
{
    GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 20; i++)
		{
            obj=GameObject.FindGameObjectWithTag("UnPlacement");
            obj.SetActive(false);
		}
    }

}
