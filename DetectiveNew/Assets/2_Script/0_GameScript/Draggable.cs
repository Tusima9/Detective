using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Draggable : MonoBehaviour
{
    public const string draggable_tag = "weapon";
    private bool dragging = false;

    private Vector2 initialPos;

    private Transform objectToDrag;
    private Image objectToDragImg;

    List<RaycastResult> hitObject = new List<RaycastResult>();

    #region 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            objectToDrag = GetDraggableUnderMouse();
            if (objectToDrag != null)
            {
                dragging = true;

                objectToDrag.SetAsLastSibling();

                initialPos = objectToDrag.position;
                objectToDragImg = objectToDrag.GetComponent<Image>();
                objectToDragImg.raycastTarget = false;
            }
        }

        if (dragging)
        {
            objectToDrag.position = Input.mousePosition;
        }
        if (Input.GetMouseButtonUp(0))
        {
            if (objectToDrag != null)
            {
                Transform objectToReplace = GetDraggableUnderMouse();

                if (objectToReplace!=null)
                {
                    objectToDrag.position = objectToReplace.position;
                    objectToReplace.position = initialPos;
                }
                else
                {
                    objectToDrag.position = initialPos;
                }

                objectToDragImg.raycastTarget = true;
                objectToDrag = null;
            }
            dragging = false;
        }
    }
    #endregion

    //function to find an object under the mouse
    private GameObject GetObjectUnderMouse()
    {
        //storing data from the unity event system imploed from the ui
        //system for storing the pointer position and recalle it from it
        var pointer = new PointerEventData(EventSystem.current);

        pointer.position = Input.mousePosition;

        //raycast at postion at pointer is at(ui elements), and store the raycast results
        EventSystem.current.RaycastAll(pointer, hitObject);

        //if object not found 
        if (hitObject.Count<=0)
        {
            return null;
        }

        return hitObject[0].gameObject;
    }

    //return the transform that matches the tag
    private Transform GetDraggableUnderMouse()
    {
        
        GameObject clickedObj = GetObjectUnderMouse();

        if (clickedObj != null && clickedObj.tag == draggable_tag)
        {
            return clickedObj.transform;
        }

        return null;
    }
}
