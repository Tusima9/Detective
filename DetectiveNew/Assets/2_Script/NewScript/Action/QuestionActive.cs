using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
namespace QAct
{

public class QuestionActive : MonoBehaviour
{
        private Button ques1, ques2, ques3, ques4, ques5;
    private GameObject TMP;
    public GameObject invPanel;
    public int i = 0;

    void Start()
    {

    }

    public void InvCall(GameObject inv)
    {
            inv.SetActive(true);
        ques1 = GameObject.Find("question1").GetComponent<Button>();
        ques2 = GameObject.Find("question2").GetComponent<Button>();
        ques3 = GameObject.Find("question3").GetComponent<Button>();
        ques4 = GameObject.Find("question4").GetComponent<Button>();
        ques5 = GameObject.Find("question5").GetComponent<Button>();

            ques1.interactable=true;
            ques2.interactable=true;
            ques3.interactable=true;
            ques4.interactable=true;
            ques5.interactable=true;

        }

}

}