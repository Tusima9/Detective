using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
//  1:ナイフ
//  2:銃
//  3:花瓶
//  4:グラス
//  5:ロープ

//  ・オープンしているか
//  0:否
//  1:正

//・答えであるか
// 0:否
// 1:正
namespace Status
{
public class WeaponStatus : MonoBehaviour
{
        [SerializeField] private GameObject Handle;
        public int Blood;
        public int Broke;
        public int Weapon;
        public int Room;
        public int Open;
        public int Answer;
    void Start()
    {
        
    }

   
}
}
