using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Texteditsize : MonoBehaviour
{
    public TMP_Text text;
    public List<int> sizeOptions = new List<int>();

    [SerializeField] Button SizeOptionsBtn = null;

    private int currentOptionSize = 0;



    private void Start()
    {
        
        SizeOptionsBtn.onClick.AddListener(ChangeSize);
    }


    
    private void ChangeSize()
    {
        currentOptionSize++;
        if (currentOptionSize >= sizeOptions.Count)
        {
            currentOptionSize = 0;
        }
        text.fontSize = sizeOptions[currentOptionSize];
    }
}
