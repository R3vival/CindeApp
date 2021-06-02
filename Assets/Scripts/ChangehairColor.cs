using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangehairColor : MonoBehaviour
{
    [Header("Sprite To Change")]
    public SpriteRenderer bodyPart;
    public SpriteRenderer backhairPart;

    [Header("Sprites To Cycle Through")]

    public List<Color> colorOptions = new List<Color>();

    [SerializeField] Button colorOptionsBtn = null;


    private int currentOptionColor = 0;



    private void Start()
    {
        colorOptionsBtn.onClick.AddListener(ChangeColor);
    }


    private void ChangeColor()
    {
        currentOptionColor++;
        if (currentOptionColor >= colorOptions.Count)
        {
            currentOptionColor = 0;
        }
        bodyPart.color = colorOptions[currentOptionColor];
        backhairPart.color = colorOptions[currentOptionColor];
    }
}
