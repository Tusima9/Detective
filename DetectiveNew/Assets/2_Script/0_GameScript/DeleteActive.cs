using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using StatusAll;
using TMPro;

public class DeleteActive : MonoBehaviour
{
    public GameObject Red;//
    public TextMeshProUGUI StatusTMS3;

    // Start is called before the first frame update
    public void Delete()
    {
        StatusTMS3.text = "探偵　オブジェクトから尋問してください";
        FindStatus.GameStatus=1f;
        Red = FindStatus.Remove;
        Red.gameObject.SetActive(false);
        this.gameObject.SetActive(false);
        FindStatus.GameStatus = 2f;
    }

    public void AnActive()
	{
        this.gameObject.SetActive(false);
	}

}
