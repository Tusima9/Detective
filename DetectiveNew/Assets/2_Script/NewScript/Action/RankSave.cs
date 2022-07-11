using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Profiling;
using TMPro;
namespace Ranking
{

public class RankSave : MonoBehaviour
{
    [SerializeField, Header("数値")]
    int point;

    [SerializeField]string[] ranking = { "ランキング1位", "ランキング2位", "ランキング3位", "ランキング4位", "ランキング5位" };
    [SerializeField]public float[] rankingValue = new float[5];

    [SerializeField, Header("表示させるテキスト")]
    TextMeshProUGUI[] rankingText = new TextMeshProUGUI[5];
        private char[] _chars = new char[6];
		void Awake()
		{
			//for (int i = 0; i < ranking.Length; i++)
			//{
			//	PlayerPrefs.SetFloat(ranking[i], 999);
			//}
		}

		// Use this for initialization
		public void callRanking(float point)
    {

        SetRanking(point);

    }

    /// <summary>
    /// ランキング呼び出し
    /// </summary>
    public void GetRanking()
    {
        //ランキング呼び出し
        for (int i = 0; i < ranking.Length; i++)
        {
            rankingValue[i] = PlayerPrefs.GetFloat(ranking[i]);
                var str=rankingValue[i].ToString("f1");
                rankingText[i].SetText(str+"s");
        }
    }
    /// <summary>
    /// ランキング書き込み
    /// </summary>
    public void SetRanking(float _value)
    {
        //書き込み用
        for (int i = 0; i < ranking.Length; i++)
        {
            //取得した値とRankingの値を比較して入れ替え
            if (_value < rankingValue[i])
            {
                var change = rankingValue[i];
                rankingValue[i] = _value;
                _value = change;
            }
        }

        //入れ替えた値を保存
        for (int i = 0; i < ranking.Length; i++)
        {
            PlayerPrefs.SetFloat(ranking[i], rankingValue[i]);
            PlayerPrefs.Save();
                Debug.Log(i);
        }
    }
}
}