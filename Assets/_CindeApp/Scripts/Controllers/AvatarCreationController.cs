///By R3-Santiago
using UnityEngine;
using UnityEngine.UI;

public class AvatarCreationController : MonoBehaviour {
    #region Declarations
    [Header("Avatar Assets")]
    [SerializeField] private InputField UserName;
    [SerializeField] private Image AvatarBody;
    [SerializeField] private Image AvatarHaircut;
    [SerializeField] private Image AvatarBackHaircut;
    [SerializeField] private Image AvatarDress;
    [SerializeField] private Image AvatarFace;
    [SerializeField] private Image AvatarMood;
    private Cinde.Avatar CurrentAvatar;
    #endregion

    void Start() {
        if (Cinde.DataController.instance.UserHasAvatar()) {
            CurrentAvatar = Cinde.DataController.instance.GetUserAvatar();
            LoadAvatar();
        }
    }

    public void LoadAvatar() {
        if (AvatarBody != null) 
            AvatarBody.sprite = Cinde.DataController.instance.GetBodyByID(CurrentAvatar.BodyShapeID);
        if (AvatarHaircut != null)
            AvatarHaircut.sprite = Cinde.DataController.instance.GetHairCutByID(CurrentAvatar.HairCutID);
        if (AvatarBackHaircut != null)
            AvatarBackHaircut.sprite = Cinde.DataController.instance.GetBackHairCutByID(CurrentAvatar.BackHairCutID);
        if (AvatarDress != null)
            AvatarDress.sprite = Cinde.DataController.instance.GetDressById(CurrentAvatar.DressID);
        if (AvatarFace != null)
            AvatarFace.sprite = Cinde.DataController.instance.GetFaceById(CurrentAvatar.FaceID);
        if (AvatarMood != null)
            AvatarMood.sprite = Cinde.DataController.instance.GetMoodById(CurrentAvatar.MoodID);
        if (UserName != null)
            UserName.text = Cinde.DataController.instance.GetUserName();
    }
    public void SetUserName(InputField name) {
        Cinde.DataController.instance.SetUserName(name.text);
    }
}
