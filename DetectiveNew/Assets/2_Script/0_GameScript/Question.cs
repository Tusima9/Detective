using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using WeaponFlag;
using StatusAll;
namespace RQuestion
{

public class Question : MonoBehaviour
{
    public TextMeshProUGUI Turn = null;
    public TextMeshProUGUI StatusTMP = null;
    static public int TurnNum = 1;
    public GameObject Selectobj;
    public GameObject Answerobj;
    public GameObject SilencePanel,ToAnswer,Clear;

    public int num1, num2, num3, num4;
    public int Anum1, Anum2, Anum3, Anum4;

    [SerializeField]
    Weaponflag[] wepons;
    bool judge;

    public GameObject True, False;
    // Start is called before the first frame update

    public void GetWeapon()
    {
        Selectobj = GameObject.Find("Select");
        Answerobj = GameObject.FindWithTag("Answer");
        num1 = Selectobj.GetComponent<Weaponflag>().Room;
            num2 = Selectobj.GetComponent<Weaponflag>().State;
        num3 = Selectobj.GetComponent<Weaponflag>().Weapon;
        num4 = Selectobj.GetComponent<Weaponflag>().Open;
        Debug.Log(num4);
        Anum1 = Answerobj.GetComponent<Weaponflag>().Room;
            Anum2 = Answerobj.GetComponent<Weaponflag>().State;
        Anum3 = Answerobj.GetComponent<Weaponflag>().Weapon;
        Anum4 = Answerobj.GetComponent<Weaponflag>().Open;
        Debug.Log(Anum1);
    }




    public void Question1()
	{
		if (num1 == Anum1)
		{
            GameObject.Find("inv").SetActive(false);
            //SilencePanel.SetActive(true);
            True.SetActive(true);
                Clear.SetActive(true);
            Invoke(nameof(TrueRes), 5f);
			}
			else
			{
                GameObject.Find("inv").SetActive(false);
                False.SetActive(true);
                Clear.SetActive(true);
                Invoke(nameof(FalseRes), 5f);
            }
        }
        public void Question2()
        {
            if (num2 == Anum2) 
            {
                GameObject.Find("inv").SetActive(false);
                True.SetActive(true);
                Clear.SetActive(true);
                Invoke(nameof(TrueRes), 5f);
            }
            else
            {
                GameObject.Find("inv").SetActive(false);
                False.SetActive(true);
                Clear.SetActive(true);
                Invoke(nameof(FalseRes), 5f);
            }
        }
        public void Question3()
        {
            if (num3 == Anum3) 
            {
                GameObject.Find("inv").SetActive(false);
                True.SetActive(true);
                Clear.SetActive(true);
                Invoke(nameof(TrueRes), 5f);
            }
            else
            {
                GameObject.Find("inv").SetActive(false);
                False.SetActive(true);
                Clear.SetActive(true);
                Invoke(nameof(FalseRes), 5f);
            }
        }
        public void Question4()
        {
            GameObject.Find("inv").SetActive(false);
            if (num4 == Anum4){
                True.SetActive(true);
                Clear.SetActive(true);
                Invoke(nameof(TrueRes), 5f);
            }
            else
            {
                GameObject.Find("inv").SetActive(false);
                False.SetActive(true);
                Clear.SetActive(true);
                Invoke(nameof(FalseRes), 5f);
            }
        }
  
        public void TrueRes()
		{
            True.SetActive(false);
            Clear.SetActive(false);
            TurnNum += 1;
            Turn.text = "Turn " + TurnNum;
            FindStatus.GameStatus = 1;
            StatusTMP.text = "The Next Turn";
            Destroy(Selectobj);
            if (TurnNum >= 3)
            {
                ToAnswer.SetActive(true);
            }
        }
        public void FalseRes()
		{
            False.SetActive(false);
            Clear.SetActive(false);
            TurnNum += 1;
            Turn.text = "Turn " + TurnNum;
            FindStatus.GameStatus = 1;
            StatusTMP.text = "The Next Turn";
            Destroy(Selectobj);
            if (TurnNum >= 12)
            {
                ToAnswer.SetActive(true);
            }
        }
        public void TurnRes()
		{

		}
    }
}

    

 
