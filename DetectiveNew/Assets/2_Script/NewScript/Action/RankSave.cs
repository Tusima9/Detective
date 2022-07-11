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
    [SerializeField, Header("���l")]
    int point;

    [SerializeField]string[] ranking = { "�����L���O1��", "�����L���O2��", "�����L���O3��", "�����L���O4��", "�����L���O5��" };
    [SerializeField]public float[] rankingValue = new float[5];

    [SerializeField, Header("�\��������e�L�X�g")]
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
    /// �����L���O�Ăяo��
    /// </summary>
    public void GetRanking()
    {
        //�����L���O�Ăяo��
        for (int i = 0; i < ranking.Length; i++)
        {
            rankingValue[i] = PlayerPrefs.GetFloat(ranking[i]);
                var str=rankingValue[i].ToString("f1");
                rankingText[i].SetText(str+"s");
        }
    }
    /// <summary>
    /// �����L���O��������
    /// </summary>
    public void SetRanking(float _value)
    {
        //�������ݗp
        for (int i = 0; i < ranking.Length; i++)
        {
            //�擾�����l��Ranking�̒l���r���ē���ւ�
            if (_value < rankingValue[i])
            {
                var change = rankingValue[i];
                rankingValue[i] = _value;
                _value = change;
            }
        }

        //����ւ����l��ۑ�
        for (int i = 0; i < ranking.Length; i++)
        {
            PlayerPrefs.SetFloat(ranking[i], rankingValue[i]);
            PlayerPrefs.Save();
                Debug.Log(i);
        }
    }
}
}