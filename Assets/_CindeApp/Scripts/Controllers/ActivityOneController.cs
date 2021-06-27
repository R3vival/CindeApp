///By R3-Santiago
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ActivityOneController : MonoBehaviour {
    #region Declarations
    [SerializeField] private GameObject activityPanel;
    [Header("Assets")]
    [SerializeField] private posterGameObject poster;
    [SerializeField] private GameObject body;
    [SerializeField] private GameObject backBtn;
    [Header("Activity Assets")]
    [SerializeField] private TMP_InputField directorInputField;
    [SerializeField] private TMP_InputField nameInputField;
    [SerializeField] private TMP_InputField actorsInputField_1;
    [SerializeField] private TMP_InputField actorsInputField_2;
    [SerializeField] private TMP_InputField actorsInputField_3;
    [SerializeField] private TMP_Dropdown genreDropDown;
    [SerializeField] private TMP_InputField yearInputField;
    [SerializeField] private TMP_InputField bandInputField;
    [SerializeField] private TMP_InputField reflexInputField;
    [SerializeField] private GameObject posterBackgroundParent;
    [SerializeField] private GameObject awardsParent;

    [Header("Avatar Assets")]
    [SerializeField] private Image AvatarBody;
    [SerializeField] private Image AvatarHaircut;
    [SerializeField] private Image AvatarBackHaircut;
    [SerializeField] private Image AvatarDress;
    [SerializeField] private Image AvatarMood;

    private Cinde.Avatar CurrentAvatar;

    
    #endregion
    #region Unity Functions
    private void Start() {
        ///Set activity panel as True to prevent failures 
        activityPanel.SetActive(true);

        ///Set current step as first
        if (Cinde.DataController.instance.GetCurrentActivityOne() == null)
            Cinde.DataController.instance.NewActivity(Cinde.DataType.ActivityOne);
        else
            LoadActivity();

        CurrentAvatar = Cinde.DataController.instance.GetUserAvatar();

        LoadAvatar();
        
    }
    #endregion
    #region Activity Functions
    public void LoadAvatar() {
        AvatarBody.sprite = Cinde.DataController.instance.GetBodyByID(CurrentAvatar.BodyShapeID);
        AvatarHaircut.sprite = Cinde.DataController.instance.GetHairCutByID(CurrentAvatar.HairCutID);

        if (CurrentAvatar.BackHairCutID < Cinde.DataController.instance.GetBackHairCutCount()) {
            AvatarBackHaircut.sprite = Cinde.DataController.instance.GetBackHairCutByID(CurrentAvatar.BackHairCutID);
            var tempColor = AvatarBackHaircut.color;
            tempColor.a = 1f;
            AvatarBackHaircut.color = tempColor;
        } else {
            var tempColor = AvatarBackHaircut.color;
            tempColor.a = 0f;
            AvatarBackHaircut.color = tempColor;
        }

        AvatarDress.sprite = Cinde.DataController.instance.GetDressById(CurrentAvatar.DressID);
        AvatarMood.sprite = Cinde.DataController.instance.GetFaceById(CurrentAvatar.FaceID);
    }
    public void LoadActivity() {
        Cinde.ActivityOne currentActivity = Cinde.DataController.instance.GetCurrentActivityOne();
        if (currentActivity != null) {
            directorInputField.text = currentActivity.Director;
            nameInputField.text = currentActivity.MovieName;
            for (int i = 0; i < currentActivity.MainActors.Count; i++) {
                switch (i) {
                    case 1:
                        actorsInputField_1.text = currentActivity.MainActors[i];
                        break;
                    case 2:
                        actorsInputField_2.text = currentActivity.MainActors[i];
                        break;
                    case 3:
                        actorsInputField_3.text = currentActivity.MainActors[i];
                        break;
                }
            }
            ///read all values of DropDown
            List<TMP_Dropdown.OptionData> listTemp = genreDropDown.options;
            for(int i = 0; i< listTemp.Count; i++) {
                if (listTemp[i].text.Equals(currentActivity.Genre))
                    genreDropDown.value = i;
            }
            yearInputField.text = currentActivity.Year.ToString();
            bandInputField.text = currentActivity.SoundBand;

            for(int i = 0;i< currentActivity.Awards.Count;i++)
                awardsParent.transform.GetChild(currentActivity.Awards[i] == 0 ? currentActivity.Awards[i]: currentActivity.Awards[i] - 1).transform.GetChild(0).gameObject.SetActive(true);


            posterBackgroundParent.transform.GetChild(currentActivity.PosterBackground == 0 ? currentActivity.PosterBackground : currentActivity.PosterBackground - 1).transform.GetChild(0).gameObject.SetActive(true);

            reflexInputField.text = currentActivity.Reflex;
        }
    }
    /// <summary>
    /// Save Movie Director
    /// </summary>    
    public void SaveMovieDirector() {
        Cinde.DataController.instance.SaveDirector(directorInputField.text);
    }
    /// <summary>
    /// Save Movie Name
    /// </summary>    
    public void SaveMovieName() {
        Cinde.DataController.instance.SaveMovieName(nameInputField.text);
    }
    /// <summary>
    /// Save Movie Main Actor
    /// </summary>
    public void SaveMovieMainActors(int index) {
        switch (index) {
            case 1:
                Cinde.DataController.instance.SaveMainActor(actorsInputField_1.text, GetIndex(actorsInputField_1.name));
                break;
            case 2:
                Cinde.DataController.instance.SaveMainActor(actorsInputField_2.text, GetIndex(actorsInputField_2.name));
                break;
            case 3:
                Cinde.DataController.instance.SaveMainActor(actorsInputField_3.text, GetIndex(actorsInputField_3.name));
                break;
        }

    }
    /// <summary>
    /// Save Movie Genre
    /// </summary>
    public void SaveMovieGenre() {
        Cinde.DataController.instance.SaveMovieGenre(genreDropDown.options[genreDropDown.value].text);
    }
    /// <summary>
    /// Save Movie Year
    /// </summary>
    public void SaveMovieYear() {
        Cinde.DataController.instance.SaveMovieYear(int.Parse(yearInputField.text));
    }
    /// <summary>
    /// Save Movie sound band
    /// </summary>
    public void SaveMovieBand() {
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
        if (Cinde.DataController.instance.SaveMovieAward(GetIndex(Award.name) - 1))
            Award.SetActive(true);
        else
            Award.SetActive(false);
    }
    /// <summary>
    /// Save movie Reflex
    /// </summary>
    public void SaveReflex() {
        Cinde.DataController.instance.SaveMovieReflex(reflexInputField.text);
    }
    /// <summary>
    /// Show Poster
    /// </summary>
    public void ShowPoster() {
        poster.DrawPoster(Cinde.DataController.instance.GetCurrentActivityOne());
    }
    public void BackPoster() {
        poster.gameObject.SetActive(false);
    }
    /// <summary>
    /// Save movie To DB
    /// </summary>
    public void SaveActivity() {
        Cinde.DataController.instance.SaveActivity();
        transform.GetComponent<SceneManagment>().LoadMainMenu();
    }
    private int GetIndex(string text) {
        ///Sprint GameObject name to get actor index
        string indexStrg = text.Split('_')[1];
        ///Parsing string to index
        return int.Parse(indexStrg);
    }
    #endregion
}
public enum Genres {
    Accion,
    Terror,
    Suspenso,
    Comedia,
    Drama,
}
