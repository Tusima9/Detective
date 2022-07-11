using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using StatusChange;

namespace handle
{

    public class Handle : MonoBehaviour
    {
        private GameStatus _gameStatus;
        //Active—p‚Ì•Ï”éŒ¾
        public static GameObject Activehandle;
        public GameObject panel;
        private int _StatusNum;

        void Start()
        {
            _gameStatus = FindObjectOfType<GameStatus>();
        }

        public void GiveHandle()
        {
            if (_gameStatus.StatusNum == 1)
            {
                Activehandle = this.gameObject;
                panel.SetActive(true);
            }
        }
    }
}
