using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Status;
using Scenes;
using _Time;

namespace Answer
{
	public class AnswerJudge : MonoBehaviour
	{
		public GameObject Select;
		private SceneManage _SceneManage;
		private CountTimer _CountTimer;
		[SerializeField] private GameObject WPanel, LPanel;
		[SerializeField] private int Anum, num; 
		
		void Start()
		{
			_SceneManage = FindObjectOfType<SceneManage>();
			_CountTimer = FindObjectOfType<CountTimer>();
			Anum = 1;
		}
		public void AnswerChoose(string name)
		{
			Select = GameObject.Find(name);
			num = Select.GetComponent<WeaponStatus>().Answer;
			if (num == Anum)
			{
				WPanel.SetActive(true);
				GameObject.Find("AnswerCanvas").SetActive(false);
				_CountTimer.callStop();
			}
			else
			{
				LPanel.SetActive(true);
				GameObject.Find("AnswerCanvas").SetActive(false);
				_CountTimer.callStop();
			}
		}
		
	}

}
