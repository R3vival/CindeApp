using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangehairColor : MonoBehaviour
{
    [Header("Sprite To Change")]
    public Image bodyPart;
    public Image backhairPart;

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
        if(Cinde.DataController.instance.GetUserAvatar().BackHairCutID != 99) {
            Color tempColor = backhairPart.color;
            tempColor.a = 1f;
            backhairPart.color = tempColor;
            backhairPart.color = colorOptions[currentOptionColor];
        } else {
            Color tempColor = backhairPart.color;
            tempColor.a = 0f;
            backhairPart.color = tempColor;
        }
        Cinde.DataController.instance.SetUserHairColor(currentOptionColor);
    }
}
