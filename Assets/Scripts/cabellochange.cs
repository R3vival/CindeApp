using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cabellochange : MonoBehaviour
{
    [Header("Sprite To Change")]
    public SpriteRenderer hair;
    public SpriteRenderer backHair;

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

        if (currentOption < 3)
        {
            backHair.sprite = backhairOptions[currentOption];
            
        }
        else
        {
            backHair.sprite = null;
        }
    }

}
