using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Status;
using Deploy;
using TMPro;
using TMPText;
public class Popup : MonoBehaviour
{
    public GameObject obj;
    public GameObject amb;
    private string weaponName;
    [SerializeField] private TextMeshProUGUI TMP;
    private CText _CText;
    public int pullnum;

    public void Getpullnum()
	{
	}
    public void Popupset(int num)
    {
        switch (num)
        {
            case 0:
                weaponName = I2.Loc.ScriptLocalization.Game.Weapon_1;
                TMP.text = weaponName;
                break;
            case 1:
                weaponName = I2.Loc.ScriptLocalization.Game.Weapon_2;
                TMP.text = weaponName;
                break;
            case 2:
                weaponName = I2.Loc.ScriptLocalization.Game.Weapon_3;
                TMP.text = weaponName;
                break;
            case 3:
                weaponName = I2.Loc.ScriptLocalization.Game.Weapon_4;
                TMP.text = weaponName;
                break;
            case 4:
                weaponName = I2.Loc.ScriptLocalization.Game.Weapon_5;
                TMP.text = weaponName;
                break;
            case 5:
                weaponName = I2.Loc.ScriptLocalization.Game.Weapon_6;
                TMP.text = weaponName;
                break;
            case 6:
                weaponName = I2.Loc.ScriptLocalization.Game.Weapon_7;
                TMP.text = weaponName;
                break;
            case 7:
                weaponName = I2.Loc.ScriptLocalization.Game.Weapon_8;
                TMP.text = weaponName;
                break;
            case 8:
                weaponName = I2.Loc.ScriptLocalization.Game.Weapon_9;
                TMP.text = weaponName;
                break;
            case 9:
                weaponName = I2.Loc.ScriptLocalization.Game.Weapon_10;
                TMP.text = weaponName;
                break;
            case 10:
                weaponName = I2.Loc.ScriptLocalization.Game.Weapon_11;
                TMP.text = weaponName;
                break;
            case 11:
                weaponName = I2.Loc.ScriptLocalization.Game.Weapon_12;
                TMP.text = weaponName;
                break;
        }
        var parent = obj.transform;
		if (Input.mousePosition.y <= 400)
		{
        amb=Instantiate(this.gameObject,new Vector3 (Input.mousePosition.x,Input.mousePosition.y+200,0),Quaternion.identity,parent);
        }
		else
		{
        amb=Instantiate(this.gameObject,new Vector3 (Input.mousePosition.x,Input.mousePosition.y-200,0),Quaternion.identity,parent);
		}

        Debug.Log(weaponName);
    }
    public void Delete()
	{
        Destroy(amb);
	}
    void Start()
    {
        
    }

    }


