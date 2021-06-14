using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class dragHandler : MonoBehaviour, IDragHandler, IEndDragHandler, IBeginDragHandler
{
    public static GameObject itemDragging;
    Vector3 startPosition;
    Transform startParent;
    Transform dragParent;
    void Start()
    {
        dragParent = GameObject.FindGameObjectWithTag("DragParent").transform;
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("OnBeginDrag");
        itemDragging = gameObject;

        startPosition = transform.position;
        startParent = transform.parent;
        transform.SetParent(dragParent);
    }
    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("OnDrag");
        transform.position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0f);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("OnEndDrag");
        itemDragging = null;

        if (transform.parent == dragParent)
        {
            transform.position = startPosition;
            transform.SetParent(startParent);
        }
    }

    void Update()
    {

    }
}
