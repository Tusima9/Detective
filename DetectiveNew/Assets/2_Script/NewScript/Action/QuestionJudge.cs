using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Status;
using SE;
using StatusChange;
using TMPText;

namespace QJudge
{
    public class QuestionJudge : MonoBehaviour
    {
        public int[] num=new int[5];
        public int[] Anum=new int[5];
        [SerializeField] private GameObject[] TMP=new GameObject[6]; 
        public GameObject Select,Answer,Invpanel,Answercanvas,True,False,TPanel,FPanel;
        private GameStatus _Turn;
        private CText _CText;
        private SoundEffect _SoundEffect;
        void Start()
        {
            _Turn = FindObjectOfType<GameStatus>();
            _CText = FindObjectOfType<CText>();
            _SoundEffect = FindObjectOfType<SoundEffect>();
        }
        public void QuesRocate(GameObject _select)
		{
            Select = _select.gameObject;
            Answer = GameObject.FindGameObjectWithTag("Answer");
            num[0] = _select.GetComponent<WeaponStatus>().Blood;
            num[1] = _select.GetComponent<WeaponStatus>().Broke;
            num[2] = _select.GetComponent<WeaponStatus>().Weapon;
            num[3] = _select.GetComponent<WeaponStatus>().Room;
            num[4] = _select.GetComponent<WeaponStatus>().Open;
            Anum[0] = Answer.GetComponent<WeaponStatus>().Blood;
            Anum[1] = Answer.GetComponent<WeaponStatus>().Broke;
            Anum[2] = Answer.GetComponent<WeaponStatus>().Weapon;
            Anum[3] = Answer.GetComponent<WeaponStatus>().Room;
            Anum[4] = Answer.GetComponent<WeaponStatus>().Open;
        } 

        public void QuesJudge(int QuesNum)
		{
            Invpanel.SetActive(false);

			switch (QuesNum)
			{
                case 1:
					if (num[0] == Anum[0])
					{
                        _CText.LogChange1(Select.name, true,_Turn.TurnNum,TMP[_Turn.TurnNum-1]);
                        True.SetActive(true);
                        Invoke(nameof(PActiveT), 5f);

                    }
                    else
					{
                        _CText.LogChange1(Select.name, false, _Turn.TurnNum,TMP[_Turn.TurnNum-1]);
                        False.SetActive(true);
                        Invoke(nameof(PActiveF), 5f);
                    }
                    break;
                case 2:
                    if (num[1] == Anum[1])
                    {
                        _CText.LogChange2(Select.name, true, _Turn.TurnNum, TMP[_Turn.TurnNum - 1]);
                        True.SetActive(true);
                        Invoke(nameof(PActiveT), 5f);

                    }
                    else
                    {
                        _CText.LogChange2(Select.name, false, _Turn.TurnNum, TMP[_Turn.TurnNum - 1]);
                        False.SetActive(true);
                        Invoke(nameof(PActiveF), 5f);
                    }
                    break;
                case 3:
                    if (num[2] == Anum[2])
                    {
                        _CText.LogChange3(Select.name, true, _Turn.TurnNum, TMP[_Turn.TurnNum - 1]);
                        True.SetActive(true);
                        Invoke(nameof(PActiveT), 5f);

                    }
                    else
                    {
                        _CText.LogChange3(Select.name, false, _Turn.TurnNum, TMP[_Turn.TurnNum - 1]);
                        False.SetActive(true);
                        Invoke(nameof(PActiveF), 5f);
                    }
                    break;
                case 4:
                    if (num[3] == Anum[3])
                    {
                        _CText.LogChange4(Select.name, true, _Turn.TurnNum, TMP[_Turn.TurnNum - 1]);
                        True.SetActive(true);
                        Invoke(nameof(PActiveT), 5f);

                    }
                    else
                    {
                        _CText.LogChange4(Select.name, false, _Turn.TurnNum, TMP[_Turn.TurnNum - 1]);
                        False.SetActive(true);
                        Invoke(nameof(PActiveF), 5f);

                    }
                    break;
                case 5:
                    if (num[4] == Anum[4])
                    {
                        _CText.LogChange5(Select.name, true, _Turn.TurnNum, TMP[_Turn.TurnNum - 1]);
                        True.SetActive(true); 
                        Invoke(nameof(PActiveT), 5f);

                    }
                    else
                    {
                        _CText.LogChange5(Select.name, false, _Turn.TurnNum, TMP[_Turn.TurnNum - 1]);
                        False.SetActive(true);
                        Invoke(nameof(PActiveF), 5f);
                        //Invoke(nameof(FalseRes), 2f);
                    }
                    break;
            }
		}
        public void TrueRes()
        {
            True.SetActive(false);
			if (_Turn.TurnNum >= 6)
			{
                Answercanvas.SetActive(true);
            }
			else
			{
            _Turn.CallTurn();
            _Turn.CallStatus(1);

			}
        }
        public void FalseRes()
        {
            False.SetActive(false);
            if (_Turn.TurnNum >= 6)
            {
                Answercanvas.SetActive(true);
            }
			else
			{
            _Turn.CallTurn();
            _Turn.CallStatus(1);

			}
        }
        public void PActiveT()
        {
            TPanel.SetActive(false);
        }
        public void PActiveF()
		{
            FPanel.SetActive(false);
		}
    }
}
