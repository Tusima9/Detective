using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
//  1:�
//  2:�i�C�t(���X)
//  3:�n�T�~
//  4:�e
//  5:���[�v

//  �E�I�[�v�����Ă��邩
//  0:��
//  1:��

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

            //�����Ə�Ԃ̕t�^


        }
           void Start()
            {

            }
    }
}
