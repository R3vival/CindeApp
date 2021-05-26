///By R3-Santiago
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class posterGameObject : MonoBehaviour
{
    #region Declarations
    [Header("Poster Components")]
    [SerializeField] private Image PosterBackground;
    [SerializeField] private TextMeshProUGUI MovieName;
    [SerializeField] private TextMeshProUGUI MovieSlogan;
    [SerializeField] private TextMeshProUGUI MovieActors;
    [SerializeField] private Image Character;

    [Header("Poster Assets")]
    public List<Sprite> BackgroundImages, CharactersImages;

    #endregion
    #region Poster GameObject Functions
    public void DrawPoster(Cinde.ActivityOne movie) {
        MovieName.text = movie.MovieName;
        MovieSlogan.text = movie.Slogan;

        for(int i = 0; i< movie.MainActor.Count;i++) {
            if (i == 0)
                MovieActors.text = movie.MainActor[i];
            else
                MovieActors.text +=" • "+ movie.MainActor[i];
        }

        PosterBackground.sprite = BackgroundImages[movie.PosterBackground];
        Character.sprite = CharactersImages[movie.MainCharacter];
    }
    #endregion
}
