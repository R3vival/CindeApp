///By R3-Santiago
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemPool : MonoBehaviour, IDropHandler
{
    [SerializeField] private string[] wordsPool;
    [SerializeField] private int maxPoolAmmount = 6;
    [SerializeField] private GameObject WordPrefab;

    [SerializeField] private int currentIndex = 0;
    #region Unity functions
    private void Awake()
    {
        if(WordPrefab != null)
            InstantiatePool();
    }
    #endregion
    #region Pool Functions
    private void InstantiatePool()
    {
        for(int i = 0; i < wordsPool.Length; i++)
        {
            dragHandler tempHandler = Instantiate(WordPrefab, this.transform).GetComponent<dragHandler>();
            tempHandler.transform.GetChild(0).GetComponent<TMP_Text>().text = wordsPool[i];
            tempHandler.itemPool = this;
            tempHandler.word = wordsPool[i];
            tempHandler.gameObject.SetActive(false);
        }

        for (int i = currentIndex; i < 6; i++)
        {
            currentIndex++;
            transform.GetChild(i).gameObject.SetActive(true);
        }
    }
    /// <summary>
    /// Remove a string from the pool
    /// </summary>
    public void RemoveFromPool(string item)
    {
        if(wordsPool.Length > 0)
        {
            if (wordsPool.Contains(item))
            {
                
                currentIndex--;

                if(transform.childCount >= maxPoolAmmount)
                {
                    for(int i = 0; i < wordsPool.Length; i++)
                    {
                        if (transform.GetChild(i).gameObject.activeSelf)
                            continue;

                        currentIndex++;
                        transform.GetChild(i).gameObject.SetActive(true);
                        break;
                    }
                }

                string[] tempWordsPool = wordsPool.Where(x => x != item).ToArray<string>();
                wordsPool = tempWordsPool;
            }   
        }
    }
    /// <summary>
    /// Add a string to the pool
    /// </summary>
    /// <param name="item"></param>
    public void AddtoPool(string item)
    {
       if(wordsPool != null)
        {
            if (!wordsPool.Contains(item))
            {
                List<string> tempWordsPool = new List<string>(wordsPool.ToList<string>());

                tempWordsPool.Add(item);

                wordsPool = tempWordsPool.ToArray<string>();
            }
                
        }
    }
    public void OnDrop(PointerEventData eventData)
    {
        GameObject tempObject = dragHandler.itemDragging;
        tempObject.transform.SetParent(transform);

        if (currentIndex == 6)
            tempObject.SetActive(false);

        AddtoPool(tempObject.transform.GetChild(0).GetComponent<TMP_Text>().text);
    }
    #endregion
}
