using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragHandler: MonoBehaviour, IDragHandler, IEndDragHandler, IBeginDragHandler
{
    public static GameObject itemDragging;
    Vector3 starPosition;
    Transform starParent;
    Transform dragParent;

    void Start()
    {
        dragParent = GameObject.FindGameObjectWithTag("DragParent").transform;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("OnBeginDrag");
        itemDragging = gameObject;

        starPosition = transform.position;
        starParent = transform.parent;

        transform.SetParent(dragParent);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("OnEndDrag");
        itemDragging = null;

        if (transform.parent == dragParent){
            transform.position = starPosition;
            transform.SetParent(starParent);
        }


    }

    void IDragHandler.OnDrag(PointerEventData eventData)
    {
        Debug.Log("OnDrag");
        transform.position = Input.mousePosition;
    }

   
    void Update()
    {
        
    }

}
