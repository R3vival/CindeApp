using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EditCharacter : MonoBehaviour
{
    [Header("Sprite To Change")]
    public SpriteRenderer bodyPart;

    [Header("Sprites To Cycle Through")]

    public List<Sprite> options = new List<Sprite>();
    
    [SerializeField] Button hairOptionsBtn = null;

    private int currentOption = 0;


    private void Start()
    {
        hairOptionsBtn.onClick.AddListener(NextOption);
    }
    private void NextOption()
    {
        currentOption++;
        if (currentOption >= options.Count)
        {
            currentOption = 0;
        }
        bodyPart.sprite = options[currentOption];
    }

   

}
