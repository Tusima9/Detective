using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPText;
using TMPro;
using handle;

namespace StatusChange
{

    public class GameStatus : MonoBehaviour
    {
        //Status
        //1=íTçı
        //2=êqñ‚
        public int TurnNum,StatusNum;
        private Handle _handle ;
        [SerializeField] private GameObject TurnAppera;
        private CText _CText;
        public TextMeshProUGUI TMPObj,TurnObj;
        public Canvas _Maincanvas;

        void Start()
        {
            _CText = FindObjectOfType<CText>();
        }

        public void SetStatus()
        {
            TurnAppera.SetActive(true);
            Invoke(nameof(TurnDelete), 2f);
         

            TurnNum = 1;
            StatusNum = 1;
        }

        public void CallTurn()
	    {
            TurnNum += 1;
            _CText.TurnChange(TurnNum,TMPObj);
            TurnObj.text = ("Turn"+TurnNum);
            TurnAppera.SetActive(true);
            Invoke(nameof(TurnDelete), 2f);
	    }
        public void TurnDelete()
		{
            TurnAppera.SetActive(false);
            _Maincanvas.sortingOrder = -1;
        }
        public void CallStatus(int num)
		{
            StatusNum = num;
		}
    }
}
