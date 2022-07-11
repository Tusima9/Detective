using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetDoc : MonoBehaviour
{
	public float fadeTime = 1f;
	private float currentRemainTime;
	[SerializeField] private SpriteRenderer spRenderer;
	[SerializeField] private GameObject Detective;
	[SerializeField] private GameObject Doctor;
	void Start()
	{
		currentRemainTime = fadeTime;
		spRenderer = GetComponent<SpriteRenderer>();
		//spDet = Detective.GetComponent<SpriteRenderer>();
		//spDoc = Doctor.GetComponent<SpriteRenderer>();
	}
	public void DeteClear()
	{
		// DeteColor = new Detective.GetComponent<Image>().color;
		
	}
    void Update()
	{
		currentRemainTime -= Time.deltaTime;
		float alpha = currentRemainTime / fadeTime;
		var color = spRenderer.color;
		color.a = alpha;
		spRenderer.color = color;
		Invoke(nameof(DeteClear), 3.0f);
	}
	public void DocClear()
	{

	}
    public void DoctorApp()
	{

	}
        
    
}
