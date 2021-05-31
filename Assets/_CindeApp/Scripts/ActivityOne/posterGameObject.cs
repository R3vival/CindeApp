///By R3-Santiago
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class posterGameObject : MonoBehaviour {
    #region Declarations
    [Header("Poster Components")]
    [SerializeField] private Image PosterBackground;

    [SerializeField] private TextMeshProUGUI    MovieDirector,
                                                MovieName,
                                                MovieActor_1,
                                                MovieActor_2,
                                                MovieActor_3,
                                                Year,
                                                SoundBand,
                                                Genre;
    [SerializeField] private Image Character;
    [Space]
    [SerializeField] private Transform AwardContainer;
    [SerializeField] private GameObject AwardBase;

    [Header("Poster Assets")]
    public List<Sprite> BackgroundImages;
    public List<Color> backgroundImageColors;
    #endregion
    #region Poster GameObject Functions
    public void DrawPoster(Cinde.ActivityOne movie) {
        MovieName.text = movie.MovieName;

        //for (int i = 0; i < movie.MainActors.Count; i++) {
        //    if (i == 0)
        //        MovieActors.text = movie.MainActors[i];
        //    else
        //        MovieActors.text += " • " + movie.MainActors[i];
        //}

        PosterBackground.sprite = BackgroundImages[0];
        PosterBackground.color = backgroundImageColors[movie.PosterBackground - 1];

        Character.sprite = CharactersImages[0];
        //Character.color = characterImageColors[movie.MainCharacter-1];
        gameObject.SetActive(true);
    }
    #endregion
}
