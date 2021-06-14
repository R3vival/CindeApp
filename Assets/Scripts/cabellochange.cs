using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cabellochange : MonoBehaviour
{
    [Header("Sprite To Change")]
    public Image hair;
    public Image backHair;

    [Header("Sprites To Cycle Through")]

    public List<Sprite> hairOptions = new List<Sprite>();
    public List<Sprite> backhairOptions = new List<Sprite>();

    [SerializeField] Button hairOptionsBtn = null;

    private int currentOption = 0;


    private void Start()
    {
        hairOptionsBtn.onClick.AddListener(NextOption);
    }
    private void NextOption()
    {
        currentOption++;
        if (currentOption >= hairOptions.Count)
        {
            currentOption = 0;
        }
        hair.sprite = hairOptions[currentOption];
        Cinde.DataController.instance.SetUserHairCut(currentOption);

        if (currentOption < 3)
        {
            var tempColor = backHair.color;
            tempColor.a = 1f;
            backHair.color = tempColor;
            backHair.sprite = backhairOptions[currentOption];
            Cinde.DataController.instance.SetUserBackHairCut(currentOption);
        }
        else
        {
            backHair.sprite = null;
            var tempColor = backHair.color;
            tempColor.a = 0f;
            backHair.color = tempColor;
            Cinde.DataController.instance.SetUserBackHairCut(99);
        }
    }

}
