using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using RQuestion;

namespace StatusAll
{
    public class FindStatus : MonoBehaviour
    {
        //Status
        //0:�J�[�h�B��
        //1:�J�[�h�߂���
        //2:����
        //

        static public float GameStatus;
        public static GameObject Remove;
        public GameObject Onoff;
        Transform Onoff2;
        public TextMeshProUGUI StatusTexts =null;
        //[SerializeField]private float 

        public void StatusChoice()
        {

        
            if (GameStatus == 1f)
            {
                if (Input.GetMouseButton(0))
                {
                    Onoff = GameObject.Find("GameElements");
                    Onoff2 = Onoff.transform.Find("RemoveOnOff");
                    Remove = this.gameObject;
                    Onoff2.gameObject.SetActive(true);
                    //GameStatus = true;
                }
            }
            if (GameStatus == 2f)
			{
                
			}
        }

    }
}
