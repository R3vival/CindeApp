using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ActivityEightController : MonoBehaviour
{
    [SerializeField] private Image memeBackground;
    [SerializeField] private InputField memeTextOne;
    [SerializeField] private InputField memeTextTwo;

    [Header("Assets")]
    [SerializeField] private Toggle[] memeBackgroundToggles;
    [SerializeField] private Sprite[] memeBackgrounds;

    private void Start() {
        if (Cinde.DataController.instance.ActEightGetCurrentActivity() == null)
            Cinde.DataController.instance.NewActivity(Cinde.DataType.ActivityEight);
        else
            LoadActivity();
    }

    public void SaveMemeBackground(int index) {
        Cinde.DataController.instance.ActEightSetMemeBackground(index);
        memeBackground.sprite =  memeBackgrounds[index];        
    }
    public void SaveMemeTextOne() {
        Cinde.DataController.instance.ActEightSetTextOne(memeTextOne.text);
    }
    public void SaveMemeTextTwo() {
        Cinde.DataController.instance.ActEightSetTextTwo(memeTextTwo.text);
    }    

    public void LoadActivity() {
        memeTextOne.text = Cinde.DataController.instance.ActEightGetTextOne();
        memeTextTwo.text = Cinde.DataController.instance.ActEightGetTextTwo();
        memeBackground.sprite = memeBackgrounds[Cinde.DataController.instance.ActEightGetMemeBackground()];
        memeBackgroundToggles[Cinde.DataController.instance.ActEightGetMemeBackground()].isOn = true;
    }
}