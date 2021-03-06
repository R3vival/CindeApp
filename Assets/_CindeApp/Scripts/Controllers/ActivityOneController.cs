///By R3-Santiago
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ActivityOneController : MonoBehaviour
{
    #region Declarations
    [SerializeField] private GameObject activityPanel;
    [Header("Assets")]
    [SerializeField] private posterGameObject poster;
    [SerializeField] private GameObject body;
    [SerializeField] private GameObject backBtn;

    #endregion
    #region Unity Functions
    private void Start() {
        ///Set activity panel as True to prevent failures 
        activityPanel.SetActive(true);

        ///Set current step as first
        Cinde.DataController.instance.NewActivity();
    }
    #endregion
    #region Activity Functions
    /// <summary>
    /// Save Movie Director
    /// </summary>
    /// <param name="directorInputField"></param>
    public void SaveMovieDirector(TMP_InputField directorInputField) {
        Cinde.DataController.instance.SaveDirector(directorInputField.text);
    }
    /// <summary>
    /// Save Movie Name
    /// </summary>
    /// <param name="nameInputField"></param>
    public void SaveMovieName(TMP_InputField nameInputField)
    {
        Cinde.DataController.instance.SaveMovieName(nameInputField.text);
    }
    /// <summary>
    /// Save Movie Main Actor
    /// </summary>
    /// <param name="actorsInputField"></param>
    public void SaveMovieMainActors(TMP_InputField actorsInputField) {

        Cinde.DataController.instance.SaveMainActor(actorsInputField.text, GetIndex(actorsInputField.name));
    }/// <summary>
    /// Save Movie Genre
    /// </summary>
    /// <param name="genreDropDown"></param>
    public void SaveMovieGenre(TMP_Dropdown genreDropDown) {
        Cinde.DataController.instance.SaveMovieGenre(genreDropDown.options[genreDropDown.value].text);
    }
    /// <summary>
    /// Save Movie Year
    /// </summary>
    /// <param name="yearInputField"></param>
    public void SaveMovieYear(TMP_InputField yearInputField) {
        Cinde.DataController.instance.SaveMovieYear(int.Parse(yearInputField.text));
    }
    /// <summary>
    /// Save Movie sound band
    /// </summary>
    /// <param name="bandInputField"></param>
    public void SaveMovieBand(TMP_InputField bandInputField) {
        Cinde.DataController.instance.SaveMovieSoundBand(bandInputField.text);
    }
    /// <summary>
    /// Save Movie Poster Background
    /// </summary>
    /// <param name="index"></param>
    public void SavePosterBackground(int index) {
        Cinde.DataController.instance.SaveMoviePosterBackground(index);
    }
    public void SavePosterAward(GameObject Award) {
        if (!Cinde.DataController.instance.SaveMovieAward(GetIndex(Award.name)))
            Award.SetActive(true);
        else
            Award.SetActive(false);
    }
    /// <summary>
    /// Save movie Reflex
    /// </summary>
    /// <param name="reflexInputField"></param>
    public void SaveReflex(TMP_InputField reflexInputField) {
        Cinde.DataController.instance.SaveMovieReflex(reflexInputField.text);
    }
    /// <summary>
    /// Show Poster
    /// </summary>
    public void ShowPoster() {
        backBtn.SetActive(true);
        poster.DrawPoster(Cinde.DataController.instance.getcurrentActivity());
    }
    public void BackPoster() {
        backBtn.SetActive(false);
        poster.gameObject.SetActive(true);
    }
    /// <summary>
    /// Save movie To DB
    /// </summary>
    public void SaveActivity() {
            Cinde.DataController.instance.SaveActivity();
    }
    private int GetIndex(string text) {
        ///Sprint GameObject name to get actor index
        string indexStrg = text.Split('_')[1];
        ///Parsing string to index
        return int.Parse(indexStrg);
    }
    #endregion
    
}
public enum Genres
{
    Accion,
    Terror,
    Suspenso,
    Comedia,
    Drama,
}
