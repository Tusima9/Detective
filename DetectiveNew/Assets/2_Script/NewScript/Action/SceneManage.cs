using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Scenes
{

	public class SceneManage : MonoBehaviour
	{
		void Start()
		{

		}
		public void WinScene()
		{
			SceneManager.LoadScene(3);
		}
		public void LoseScene()
		{
			SceneManager.LoadScene(4);
		}
		public void backMenu()
		{
			SceneManager.LoadScene(0);
		}
	}

}