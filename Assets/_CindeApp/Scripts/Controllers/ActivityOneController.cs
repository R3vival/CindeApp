using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ActivityOneController : MonoBehaviour
{
    #region Declarations
    [SerializeField] private GameObject stepOnePanel, stepTwoPanel, stepThreePanel;
    [Space]
    [SerializeField] private Steps currentStep;
    [Header("Assets")]
    [SerializeField] private TMP_InputField nameInputField;
    [SerializeField] private TMP_InputField sloganInputField;

    #endregion
    #region Unity Functions
    private void Start() {
        ///First panel active self equals true
        ///Second and Third panel active self equals false
        stepOnePanel.SetActive(true);
        stepTwoPanel.SetActive(false);
        stepThreePanel.SetActive(false);

        ///Set current step as first
        currentStep = Steps.First;
    }
    #endregion
    #region Activity Functions
    public void ShowHidePanel(GameObject panel)
    {
        switch (currentStep)
        {
            case Steps.First:
                currentStep = Steps.Second;
                break;
            case Steps.Second:
                currentStep = Steps.Third;
                break;
            case Steps.Third:
            default:
                break;
        }
        panel.SetActive(!panel.activeSelf);
    }
    public void SaveMovieName()
    {
        Cinde.DataController.instance.SaveMovieName(nameInputField.text);
    }
    public void SaveMovieSlogan()
    {
        Cinde.DataController.instance.SaveMovieSlogan(sloganInputField.text);
    }
    public void SavePosterBackground(int index) {
        Cinde.DataController.instance.SaveMoviePosterBackground(index);
    }
    #endregion
    
}
public enum Steps
{
    First,
    Second,
    Third
}
