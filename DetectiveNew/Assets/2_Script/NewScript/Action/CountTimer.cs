using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;
using Ranking;
//カウントアップするタイマー
namespace _Time
{

public class CountTimer : MonoBehaviour
{
    [SerializeField]private float _time;
    [SerializeField] private bool Timercheck;
    [SerializeField] private TextMeshProUGUI Timer,TMP;
    private RankSave _RankSave;
    // Start is called before the first frame update
    void Start()
    {
        _RankSave = FindObjectOfType<RankSave>();
        Timercheck = false;
    }

    // Update is called once per frame
    void Update()
    {
		if (Timercheck == false)
		{
        _time+=Time.deltaTime;
        Timer.text = _time.ToString("f1");

		}
    }
    public void callStop()
	{
        Timercheck = true;
        TMP.text = _time.ToString("f1");
        _RankSave.callRanking(_time);
	}
    public void timeStop()
		{
            Timercheck = true;
		}
}

}