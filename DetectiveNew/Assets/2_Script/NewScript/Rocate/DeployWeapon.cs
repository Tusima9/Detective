using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Status;
namespace Deploy
{

    public class DeployWeapon : MonoBehaviour
    {
        [SerializeField] private GameObject[] Weapons = new GameObject[12];
        [SerializeField] private GameObject[] Actions = new GameObject[32];
        public GameObject objHandle;
        public int Count, WeaponNum, Handle;
        [SerializeField] private int room1, room2, room3, room4;
        private int[] Num = new int[32];
        private int[] MainNum = new int[32];
        private GameObject[] obj = new GameObject[12];
        static public Vector3[] Rocate = new Vector3[12];
        private int Answer;

        void Start()
        {
            Count = 0;
            //必須作業
            for (int i = 0; i < 32; i++)
            {
                Num[i] = i + 1;
            }
            //ランダムな値の決定
            do
            {
                WeaponNum = Random.Range(1, 31);
                Debug.Log(Count + " : " + WeaponNum);
                MainNum[Count] = WeaponNum;
                Deploy(WeaponNum);
                Count++;
            } while (Handle <= 12);

            Answer = Random.Range(0, 12);
            Debug.Log(Answer);

            for (int b = 0; b < 12; b++)
            {
                //配置
                Debug.Log(b + "  " + MainNum[b]);
                Actions[MainNum[b]].tag = "Placement";
                Rocate[b] = Actions[MainNum[b]].transform.position;
                obj[b] = Instantiate(Weapons[b], Rocate[b], Quaternion.identity, objHandle.transform);
                obj[b].name = Weapons[b].name;
                Destroy(Weapons[b]);
                Debug.Log(Rocate[b]);

                //部屋設定
                var room = obj[b].GetComponent<WeaponStatus>().Room;

                if (MainNum[b] < 9&&0<=MainNum[b])
                {
                    room = 1;
                }
                else if (MainNum[b] < 17)
                {
                    room = 2;
                }
                else if (MainNum[b] < 25)
                {
                    room = 3;
                }
                else if (MainNum[b] < 33)
                {
                    room = 4;
                }
                obj[b].GetComponent<WeaponStatus>().Room = room;

                //正解の設定
                if (b == Answer)
                {
                    obj[b].tag = "Answer";
                    obj[b].GetComponent<WeaponStatus>().Answer = 1;

                }
            }

        }


        //判別
        public void Deploy(int Number)
        {
            if (Count == 0) { Handle += 1; return; }

            for (int i = 0; i < Num[Count - 1]; i++)
            {
                if (MainNum[i] == Number)
                {
                    Count -= 1;
                    return;
                }

            }
            Roomjudge(Number);
            Handle += 1;
            return;
        }
        public void Roomjudge(int num)
        {
            if (num < 8 && room1 < 4)
            {
                room1 += 1;
            }
            else if (8 < num && num < 16 && room2 < 4)
            {
                room2 += 1;
            }
            else if (16 < num && num < 24 && room3 < 4)
            {
                room3 += 1;
            }
            else if (24 < num && num < 32 && room4 < 4)
            {
                room4 += 1;
            }
            else
            {
                //Count -= 1;
                return;
            }
            //if (room1 <= 1||room2<=1 || room3 <= 1 || room4 <= 1)
            //{
            //             Count -= 1;
            //}
        }
    }

}