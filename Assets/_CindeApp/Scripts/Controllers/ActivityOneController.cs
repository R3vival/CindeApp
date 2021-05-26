///By R3-Santiago
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ActivityOneController : MonoBehaviour
{
    #region Declarations
    [SerializeField] private GameObject stepOnePanel, stepTwoPanel, stepThreePanel;
    [Space]
    [SerializeField] private Steps currentStep;
    [Header("Assets")]
    [SerializeField] private TMP_InputField nameInputField;
    [SerializeField] private TMP_InputField sloganInputField;
    [SerializeField] private posterGameObject poster;

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
        Cinde.DataController.instance.NewActivity();
    }
    #endregion
    #region Activity Functions
    public void SwitchStep()
    {
        switch (currentStep)
        {
            case Steps.First:
                currentStep = Steps.Second;
                stepOnePanel.SetActive(false);
                stepTwoPanel.SetActive(true);
                stepThreePanel.SetActive(false);
                break;
            case Steps.Second:
                currentStep = Steps.Third;
                stepOnePanel.SetActive(false);
                stepTwoPanel.SetActive(false);
                stepThreePanel.SetActive(true);
                ShowPoster();
                break;
            case Steps.Third:
            default:
                break;
        }        
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
    public void SaveMovieMainCharacters(TMP_InputField characterInputField) {
        Cinde.DataController.instance.SaveMainActor(characterInputField.text);
    }
    public void SaveCharacter(int index) {
        Cinde.DataController.instance.SaveMovieCharacter(index);
    }
    public void SaveReflex(TMP_InputField reflexInputField) {
        Cinde.DataController.instance.SaveMovieReflex(reflexInputField.text);
    }
    public void ShowPoster() {
        poster.DrawPoster(Cinde.DataController.instance.getcurrentActivity());
    }
    public void SaveActivity() {
        if(currentStep == Steps.Third) {
            Cinde.DataController.instance.SaveActivity();
        }
    }
    #endregion
    
}
public enum Steps
{
    First,
    Second,
    Third
}
