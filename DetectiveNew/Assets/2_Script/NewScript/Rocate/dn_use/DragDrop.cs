using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using StatusAll;
using WeaponFlag;
using RQuestion;

public class DragDrop : MonoBehaviour, IPointerDownHandler,IBeginDragHandler,IEndDragHandler, IDragHandler
{
    public static string dragged_Tag = "Weapon";

    [SerializeField] private Canvas canvas;
    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;

    [SerializeField] private GameObject spacifyobj;
    public GameObject Write;
    private bool ClickC=false;

    [SerializeField] public float count = 0f;
    private GameObject conHandle;
    [SerializeField] private GameObject Select;

    public bool droppedOnSlot;
    Vector3 initialPos;

    private void Start()
    {
        initialPos = transform.position;
    }

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
        initialPos = transform.position;
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("OnBeginDrag");
        canvasGroup.alpha = 0.6f;
        canvasGroup.blocksRaycasts = false;
        eventData.pointerDrag.GetComponent<DragDrop>().droppedOnSlot = false;
        
        
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (FindStatus.GameStatus != 2)
        {
        rectTransform.anchoredPosition += eventData.delta/canvas.scaleFactor;
        Debug.Log("OnDrag");
        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("OnEndDrag");
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;
        count += 1;

        if (droppedOnSlot == false)
        {
            transform.position = initialPos;
        }
        if (count >= 3)
        {
            conHandle = GameObject.Find("HideButton");
            conHandle.GetComponent<Button>().interactable = true;
        }

    }

    public void OnPointerDown(PointerEventData eventData)
    {
		if (FindStatus.GameStatus == 2f)
		{
			if (ClickC == false)
			{
                if (Select) { Destroy(Select); }
            Select = (Instantiate(spacifyobj, new Vector3(0, 0, 0), Quaternion.identity));
            Select.name = "Select";
            Select.transform.SetParent(Write.transform, false);
                //ClickC = true;
			}
		}
        Debug.Log("OnPointerDown");
    }

}
