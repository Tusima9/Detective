using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//  �E����
//�@0:���m��̔z�u
//  1:����
//  2:����
//  3:�f�@��
//  4:�ҍ���

//  �E�ۑ���
//  0:�ʏ�
//  1:���h��
//  2:�j��
//  3:���G��ŉ��Ă���

//  �E����
//  0:�����`
//  1:�i�C�t
//  2:�e
//  3:�ԕr
//  4:�O���X
//  5:���[�v

//  �E�I�[�v�����Ă��邩
//  0:��
//  1:��

//�E�����ł��邩
// 0:��
// 1:��
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
