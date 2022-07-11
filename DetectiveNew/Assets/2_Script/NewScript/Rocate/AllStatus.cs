using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPText;
using TMPro;

namespace StatusChange
{

    public class Status : MonoBehaviour
    {
        //Status
        //1=íTçı
        //2=êqñ‚
        [SerializeField] private int TurnNum,StatusNum;
        private CText _CText;
        public TextMeshProUGUI TMPObj;

        void Start()
        {
            TurnNum = 1;
            _CText = FindObjectOfType<CText>();
        }

        public void CallTurn()
	    {
            TurnNum += 1;
            _CText.TurnChange(TurnNum,TMPObj);
	    }
        public void CallStatus()
		{

		}
    }
}
