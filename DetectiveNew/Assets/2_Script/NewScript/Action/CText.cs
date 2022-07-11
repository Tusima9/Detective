using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using I2.Loc;

namespace TMPText
{
public class CText : MonoBehaviour
{
        public TextMeshProUGUI ChangeText;

		
		
		public void QuesChange(int textnum,GameObject obj,TextMeshProUGUI TMP)
		{
			
			switch (textnum)
			{
				case 1:
					TMP.text = (obj.name  + LocalizationManager.GetTranslation($"Game/Question_Text-1"));
					break;
				case 2:
					TMP.text = (obj.name + LocalizationManager.GetTranslation($"Game/Question_Text-2"));
					break;
				case 3:
					TMP.text = (obj.name + LocalizationManager.GetTranslation($"Game/Question_Text-3"));
					break;
				case 4:
					TMP.text = (obj.name + LocalizationManager.GetTranslation($"Game/Question_Text-4"));
					break;
				case 5:
					TMP.text = (LocalizationManager.GetTranslation($"Game/Question_Text-5"));
					break;
			}
            
		}
		public void TurnChange(int TurnNum,TextMeshProUGUI TMP)
		{
			TMP.text = (TurnNum+"");
		}
		public void LogChange1(string Item, bool judge,int num, GameObject TMP)
		{
			if (judge)
			{
				TMP.GetComponent<TextMeshProUGUI>().text = (ScriptLocalization.Game.Log_Text_1 + num + ":" + Item + ScriptLocalization.Game.Log_Text_11);
			}
			else
			{
				TMP.GetComponent<TextMeshProUGUI>().text = (ScriptLocalization.Game.Log_Text_1 + num + ":" + Item + ScriptLocalization.Game.Log_Text_10);

			}
		}
		public void LogChange2(string Item, bool judge, int num, GameObject TMP)
		{
			if (judge)
			{
				TMP.GetComponent<TextMeshProUGUI>().text = (ScriptLocalization.Game.Log_Text_1 + num + ":" + Item + ScriptLocalization.Game.Log_Text_8);
			}
			else
			{
				TMP.GetComponent<TextMeshProUGUI>().text = (ScriptLocalization.Game.Log_Text_1 + num + ":" + Item + ScriptLocalization.Game.Log_Text_9);

			}
		}
		public void LogChange3(string Item, bool judge, int num, GameObject TMP)
		{
			if (judge)
			{
				TMP.GetComponent<TextMeshProUGUI>().text = (ScriptLocalization.Game.Log_Text_1 + num + ":" + Item + ScriptLocalization.Game.Log_Text_6);
			}
			else
			{
				TMP.GetComponent<TextMeshProUGUI>().text = (ScriptLocalization.Game.Log_Text_1 + num + ":" + Item + ScriptLocalization.Game.Log_Text_7);

			}
		}
		public void LogChange4(string Item, bool judge, int num, GameObject TMP)
		{
			if (judge)
			{
				TMP.GetComponent<TextMeshProUGUI>().text = (ScriptLocalization.Game.Log_Text_1 + num + ":" + Item + ScriptLocalization.Game.Log_Text_5);
			}
			else
			{
				TMP.GetComponent<TextMeshProUGUI>().text = (ScriptLocalization.Game.Log_Text_1 + num + ":" + Item + ScriptLocalization.Game.Log_Text_4);

			}
		}
		public void LogChange5(string Item, bool judge, int num, GameObject TMP)
		{
			if (judge)
			{
				TMP.GetComponent<TextMeshProUGUI>().text = (ScriptLocalization.Game.Log_Text_1 + num + ":" + Item + ScriptLocalization.Game.Log_Text_2);
			}
			else
			{
				TMP.GetComponent<TextMeshProUGUI>().text = (ScriptLocalization.Game.Log_Text_1 + num + ":" + Item + ScriptLocalization.Game.Log_Text_3);

			}
		}

	
		void Start()
    {
			
		}

}
}
