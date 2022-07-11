using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Weapon
{

public class Weaponspown : MonoBehaviour
{

    public GameObject prefab;
    private Camera cam;
    private Vector3 mousePosition;
    float Num=0;

    void Start()
	{
        this.cam = FindObjectOfType<Camera>();
	}

    // Update is called once per frame
    void Update()
    {
		if (Input.GetMouseButtonDown(0))
		{
            mousePosition = Input.mousePosition;
            mousePosition.z += 10f;
			if (mousePosition.y > 640)
			{
				if (mousePosition.x < 960)
				{
                this.prefab.tag = "Treat";
				}
				else
				{
					this.prefab.tag = "Live";
				}
			}
			else if (mousePosition.y > 205)
			{
				if (mousePosition.x < 960)
				{
					this.prefab.tag = "Exam";
				}
				else
				{
					this.prefab.tag = "Wait";
				}
			}
			else
			{

			}

            var worldPoint = this.cam.ScreenToWorldPoint(mousePosition);
            GameObject.Instantiate(this.prefab, worldPoint,Quaternion.identity);
            Debug.Log("座標" + mousePosition);
            Num += 1;
		}

		if (Num > 12)
		{

		}
    }
}

}