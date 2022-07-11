using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Cutinn
{

public class Cutin : MonoBehaviour
{
    [SerializeField] private GameObject CutinObj,CutinObj2;

    void Start()
    {
        
    }
    public void InCutin()
	{
        CutinObj.SetActive(true);
        Invoke(nameof(OutCutin),2.5f);
	}
    public void OutCutin()
	{
        CutinObj.SetActive(false);
	}
        public void InCutin2()
        {
            CutinObj2.SetActive(true);
            Invoke(nameof(OutCutin2), 2.5f);
        }
        public void OutCutin2()
        {
            CutinObj2.SetActive(false);
        }
    }

}