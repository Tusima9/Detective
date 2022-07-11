using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//  ・部屋
//　0:未確定の配置
//  1:書斎
//  2:居間
//  3:診察室
//  4:待合室

//  ・保存状況
//  0:通常
//  1:血塗れ
//  2:破壊
//  3:血濡れで壊れている

//  ・武器
//  0:レンチ
//  1:包丁
//  2:ナイフ(メス)
//  3:ハサミ
//  4:銃
//  5:ロープ

//  ・オープンしているか
//  0:否
//  1:正

namespace WeaponFlag {

    public class Weaponflag : MonoBehaviour
    {
        [SerializeField] private GameObject Handle;
        [SerializeField] public int Room;
        [SerializeField] public int State;
        [SerializeField] public int Weapon;
        [SerializeField] public int Open;
        [SerializeField] public int Answer;

        void Specify()
        {
            Room = 0;
            State = 0;
            Weapon = 0;
            Open = 0;
            Answer = 0;

            //武器種と状態の付与


        }
           void Start()
            {

            }
    }
}
