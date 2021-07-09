///By R3-Santiago
using UnityEngine;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    #region Declarations
    [Header("Avatar Assets")]
    [SerializeField] private Text PlayerName;
    [SerializeField] private Image AvatarBody;
    [SerializeField] private Image AvatarHaircut;
    [SerializeField] private Image AvatarBackHaircut;
    [SerializeField] private Image AvatarDress;
    [SerializeField] private Image AvatarFace;
    [SerializeField] private Image AvatarMood;
    private Cinde.Avatar CurrentAvatar;
    #endregion

    void Start()
    {
        if (Cinde.DataController.instance.UserHasAvatar()) {
            CurrentAvatar = Cinde.DataController.instance.GetUserAvatar();
            LoadAvatar();
        }
    }

    public void LoadAvatar() {
        PlayerName.text = "¡Hola " + Cinde.DataController.instance.GetUserName()+"!";
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
        AvatarFace.sprite = Cinde.DataController.instance.GetFaceById(CurrentAvatar.FaceID);
        AvatarMood.sprite = Cinde.DataController.instance.GetMoodById(CurrentAvatar.MoodID);
    }
}
