using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cambiarpalabras : MonoBehaviour
{
    public SpriteRenderer palabra;
    public List<Sprite> palabraOptions = new List<Sprite>();
 
    [SerializeField] Button palabraOptionsBtn = null;

    private int currentOption = 0;


    private void Start()
    {
        palabraOptionsBtn.onClick.AddListener(NextOption);
    }
    private void NextOption()
    {
        currentOption++;
        if (currentOption >= palabraOptions.Count)
        {
            currentOption = 0;
        }
        palabra.sprite = palabraOptions[currentOption];
    }
}
