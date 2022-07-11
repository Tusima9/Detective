using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Status;

public class AClone : MonoBehaviour
{
    [SerializeField]private GameObject thisobj;

    public void Clone (){
        thisobj.GetComponent<WeaponStatus>().Answer = 1;
        thisobj.tag = "Answer";
    }

    void Start()
    {
        
    }

}
