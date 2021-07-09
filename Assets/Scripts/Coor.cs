using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Sprites;
using UnityEngine.UI;

public class Coor : MonoBehaviour
{
    [Header("Sprite To Change")]
    public Image bodyPart;
  

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
        //Cinde.DataController.instance.s
    }
}
