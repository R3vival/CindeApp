using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class DropWords : MonoBehaviour, IDropHandler
{
    [SerializeField] private List<GameObject> Words;
    [SerializeField] ViolenceTypes type;

    private void Start()
    {
        Words = new List<GameObject>();
    }

    public void OnDrop(PointerEventData eventData)
    {
            GameObject tempGO = dragHandler.itemDragging;
        if (type == tempGO.GetComponent<dragHandler>().type) {
            Words.Add(tempGO);
            tempGO.transform.SetParent(transform);
            tempGO.transform.position = transform.position;
        }   
    }
    public void RemoveFromList(GameObject goToRemove)
    {
        if (Words.Contains(goToRemove))
            Words.Remove(goToRemove);
    }

    
}
[SerializeField]
public enum ViolenceTypes {
    Null,
    Simbolica,
    Fisica,
    Digital,
    Sexual,
    Economica,    
}