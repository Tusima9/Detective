using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using StatusAll;

public class Roomcheck : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI StatusTMP;
    [SerializeField] GameObject[] WeaponTransform;
    [SerializeField] GameObject Wep;

    public void Roomplace()
	{
        float rect = Wep.GetComponent<RectTransform>().localPosition.x;
            if(rect<1732)
            {
                Debug.Log("a");
			}
		
	}

    void Start()
    {
        
    }


}
