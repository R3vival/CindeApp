using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextEdit : MonoBehaviour
{
    public TMP_Text text;
    public List<TMP_FontAsset> textFontOptions = new List<TMP_FontAsset>();
    public List<Material> MaterialOptions = new List<Material>();
    

    [SerializeField] Button textFontOptionsBtn = null;
   


    private int currentOptionFont = 0;
    



    private void Start()
    {
        textFontOptionsBtn.onClick.AddListener(ChangeFont);
       
    }


    private void ChangeFont()
    {
        currentOptionFont++;
        if (currentOptionFont >= textFontOptions.Count)
        {
            currentOptionFont = 0;
        }
        text.font = textFontOptions[currentOptionFont];
        text.fontSharedMaterial = MaterialOptions[currentOptionFont];
    }

    
}
