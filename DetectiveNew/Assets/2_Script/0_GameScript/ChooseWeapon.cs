using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using StatusAll;
using WeaponFlag;
using TMPro;


public class ChooseWeapon : MonoBehaviour
{
	public GameObject thisobj;
	public GameObject Canvas;
	private GameObject Choose;
	public TextMeshProUGUI StatusTMS1 = null;



	public void AnswerWeapon()
	{
		thisobj.GetComponent<Weaponflag>().Answer = 1 ;
		thisobj.tag = "Answer";
		Choose = GameObject.Find("Choose");
		Choose.SetActive(false);
		StatusTMS1.text= "凶器をボックスの中に隠しましょう";
	}
}
