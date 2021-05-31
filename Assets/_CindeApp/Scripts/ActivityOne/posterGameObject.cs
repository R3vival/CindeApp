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
        MovieDirector.text = movie.Director;
        MovieName.text = movie.MovieName;
        
        if(movie.MainActors.Count > 0) {
            MovieActor_1.text = movie.MainActors[0];
            if(movie.MainActors.Count >= 2) {
                MovieActor_2.text = movie.MainActors.Count == 2 ? "•" : movie.MainActors[1];
                MovieActor_3.text = movie.MainActors.Count == 2 ? movie.MainActors[1] : movie.MainActors[2];
            }
        }

        Year.text = "Año: " + movie.Year;
        Genre.text = "Genero: " + movie.Genre;
        SoundBand.text = "Banda Sonora: " + movie.SoundBand;

        PosterBackground.sprite = BackgroundImages[0];
        //PosterBackground.color = backgroundImageColors[movie.PosterBackground - 1];

        //TODO SET AVATAR INTO CHARACTER 
        //Character.sprite = CharactersImages[0];
        //Character.color = characterImageColors[movie.MainCharacter-1];


        gameObject.SetActive(true);
    }
    #endregion
}
