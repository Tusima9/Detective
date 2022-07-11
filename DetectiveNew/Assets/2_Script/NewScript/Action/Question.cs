using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using QAct;
using QJudge;
using TMPText;
using TMPro;
using Status;
using StatusChange;
using Cutinn;

public class Question : MonoBehaviour
{
    public GameObject[] TMPOBJ=new GameObject[5];
    [SerializeField] private TextMeshProUGUI[] TMP = new TextMeshProUGUI[5];
    public Canvas Setting, Main;
    private Cutin _Cutin;
    private QuestionActive Qactive;
    private CText Calltext;
    private QuestionJudge _QJudge;
    private GameStatus _gameStatus;
    public GameObject invPanel;
    public int a=0 ;

    void Start()
    {

        _QJudge = FindObjectOfType<QuestionJudge>();
        Qactive=FindObjectOfType<QuestionActive>();
        Calltext = FindObjectOfType<CText>();
        _gameStatus = FindObjectOfType<GameStatus>();
        _Cutin = FindObjectOfType<Cutin>();

		if (a == 0)
		{

        for(int i = 0; i < 5; i++)
		    {
                TMPOBJ[i] = GameObject.Find("Questext"+(i+1));
                TMP[i] = TMPOBJ[i].GetComponent<TextMeshProUGUI>();
                a = 1;
		}
		    if (this.name== "Knife" && a==1)
                { 
                    invPanel.SetActive(false);
                }
		    }
	}
    //NullReferenceException: Object reference not set to an instance of an object
    //Question.Start() (at Assets/2_Script/NewScript/Action/Question.cs:41)
    public void QuestionState()
	{

        Setting.sortingOrder = -1;
        Main.sortingOrder = -1;
        if (_gameStatus.StatusNum == 2)
		{
            _Cutin.InCutin();
            Qactive.InvCall(invPanel);
            this.GetComponent<WeaponStatus>().Open = 1;
            Calltext.QuesChange(1, this.gameObject, TMP[0]);
            Calltext.QuesChange(2, this.gameObject, TMP[1]);
            Calltext.QuesChange(3, this.gameObject, TMP[2]);
            Calltext.QuesChange(4, this.gameObject, TMP[3]);
            Calltext.QuesChange(5, this.gameObject, TMP[4]);
            _QJudge.QuesRocate(this.gameObject);

		}
		else
		{
            Debug.Log("—áŠO‚ª‘}“ü‚³‚ê‚Ü‚µ‚½");
		}
	}
    

}
