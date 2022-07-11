using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using StatusAll;

public class weaponSlot : MonoBehaviour, IDropHandler
{
    

    [SerializeField] private GameObject Handle; 
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("OnDrop");
            DragDrop draggableObj = eventData.pointerDrag.GetComponent<DragDrop>();
        if (draggableObj != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            //CallHandle = ;
            this.tag = "Placement";

            eventData.pointerDrag.GetComponent<DragDrop>().droppedOnSlot = true;


		}
    }
}

