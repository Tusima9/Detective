using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Winlose : MonoBehaviour
{
	public GameObject Trueobj, Falseobj;
	public GameObject Deleteobj,TitleButton,Clear;
	public void WinloseJudge()
	{
		if (true)
		{
			Trueobj.SetActive(true);
			Clear.SetActive(true);
			Deleteobj.SetActive(false);
			Invoke(nameof(WinRes), 5f);
		}
	}
	public void WinRes()
	{
			TitleButton.SetActive(true);
	}
	public void loseRes()
	{

	}
}
