///By R3-Santiago
using UnityEngine;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    #region Declarations
    [Header("Avatar Assets")]    
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
        AvatarBody.sprite = Cinde.DataController.instance.GetBodyByID(CurrentAvatar.BodyShapeID);
        AvatarHaircut.sprite = Cinde.DataController.instance.GetHairCutByID(CurrentAvatar.HairCutID);
        AvatarBackHaircut.sprite = Cinde.DataController.instance.GetBackHairCutByID(CurrentAvatar.BackHairCutID);
        AvatarDress.sprite = Cinde.DataController.instance.GetDressById(CurrentAvatar.DressID);
        AvatarFace.sprite = Cinde.DataController.instance.GetFaceById(CurrentAvatar.FaceID);
        AvatarMood.sprite = Cinde.DataController.instance.GetMoodById(CurrentAvatar.MoodID);
    }
}
