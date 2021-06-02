﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropSlot : MonoBehaviour, IDropHandler
{
    void Start()
    {

    }

    public GameObject item;
    public void OnDrop(PointerEventData eventData)
    {
        if (!item)
        {
            item = dragHandler.itemDragging;
            item.transform.SetParent(transform);
            item.transform.position = transform.position;
        }
    }

   
   
    void Update()
    {
        if (item != null && item.transform.parent != transform)
        {
            item = null;
        }
    }
}
