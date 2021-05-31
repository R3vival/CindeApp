///By R3-Santiago
using System.Linq;
using UnityEngine;

namespace Cinde {
    public class DataController : MonoBehaviour {
        #region Declarations
        public static DataController instance;
        [SerializeField] private UserScriptableObject userData;
        [SerializeField] private ActivityOne currentActivityOne;
        #endregion

        #region UnityRegion
        private void Start() {
            if (instance)
                Destroy(this.gameObject);
            else
                instance = this;

            DontDestroyOnLoad(gameObject);
        }
        #endregion
        public User CreateUser(string name, Avatar avatar) {
            User newUser = new User();

            newUser.UserName = name;
            newUser.Avatar = avatar;

            return newUser;
        }

        /// <summary>
        /// Get the User from scriptableObject
        /// </summary>
        /// <returns></returns>
        public User GetUser() {
            return userData.user;
        }
        /// <summary>
        /// Set a User in scriptableObject
        /// </summary>
        /// <param name="user"></param>
        public void SetUser(User user) {
            userData.user = user;
        }
        /// <summary>
        /// Get current User name
        /// </summary>
        /// <returns></returns>
        public string GetUserName() {
            return userData.user.UserName;
        }
        /// <summary>
        /// Set name to Current User
        /// </summary>
        /// <param name="name"></param>
        public void SetUserName(string name) {
            userData.user.UserName = name;
        }
        /// <summary>
        /// Get Avatar from current user
        /// </summary>
        /// <returns></returns>
        public Avatar GetUserAvatar() {
            return userData.user.Avatar;
        }
        /// <summary>
        /// Set Avatar to Current User
        /// </summary>
        /// <param name="avatar"></param>
        public void SetUserAvatar(Avatar avatar) {
            userData.user.Avatar = avatar;
        }
        /// <summary>
        /// Get head shape from current User
        /// </summary>
        /// <returns></returns>
        public AvatarComponent GetUserHeadShape() {
            return userData.user.Avatar.HeadShape;
        }
        /// <summary>
        /// Set headShape in current User
        /// </summary>
        /// <param name="headShape"></param>
        public void SetUserHeadShape(AvatarComponent headShape) {
            userData.user.Avatar.HeadShape = headShape;
        }
        /// <summary>
        /// Get face from Current User
        /// </summary>
        /// <returns></returns>
        public AvatarComponent GetUserFace() {
            return userData.user.Avatar.Face;
        }
        /// <summary>
        /// Set face in current User
        /// </summary>
        /// <param name="face"></param>
        public void SetUserFace(FaceAvatarComponent face) {
            userData.user.Avatar.Face = face;
            userData.user.Avatar.mood = face.mood;
        }
        public void SetAvatarMood(Moods mood) {
            FaceAvatarComponent currentFace = userData.user.Avatar.Face;

            FaceAvatarComponent tempFace = (FaceAvatarComponent)GetFaceSetById(currentFace.setId).Where(x => x.mood == mood);
            userData.user.Avatar.Face = tempFace;
            userData.user.Avatar.mood = tempFace.mood;
        }
        #region Db
        /// <summary>
        /// Get a face from database By id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public FaceAvatarComponent GetFaceByID(int id) {
            return (FaceAvatarComponent)userData.facesList.FacesList.Where(x => x.id == id);
        }
        /// <summary>
        /// Get all faces of a set by id
        /// </summary>
        /// <param name="setId"></param>
        /// <returns></returns>
        public FaceAvatarComponent[] GetFaceSetById(int setId) {
            return (FaceAvatarComponent[])userData.facesList.FacesList.Where(x => x.setId == setId);
        }
        /// <summary>
        /// Get a face from database By id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public AvatarComponent GetDressById(int id) {
            return (AvatarComponent)userData.dressesList.DressList.Where(x => x.id == id);
        }
        /// <summary>
        /// Get all dresses of a set by id
        /// </summary>
        /// <param name="setId"></param>
        /// <returns></returns>
        public AvatarComponent[] GetDressSetById(int setId) {
            return (AvatarComponent[])userData.dressesList.DressList.Where(x => x.setId == setId);
        }
        /// <summary>
        /// Get a head shape from database by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public AvatarComponent GetFaceShapeById(int id) {
            return (AvatarComponent)userData.headsList.HeadShapesList.Where(x => x.id == id);
        }
        /// <summary>
        /// Get all face shapes of a set by id
        /// </summary>
        /// <param name="setId"></param>
        /// <returns></returns>
        public AvatarComponent[] GetFaceShapeSetsById(int setId) {
            return (AvatarComponent[])userData.headsList.HeadShapesList.Where(x => x.setId == setId);
        }
        #endregion
        #region Activity
        public void NewActivity() {
            currentActivityOne = new ActivityOne();
        }
        #endregion
        #region Activity One
        public void SaveDirector(string director) {
            currentActivityOne.Director = director;
        }
        public void SaveMovieName(string name) {
            currentActivityOne.MovieName = name;
        }
        public void SaveMainActor(string character, int index) {
            if (character != "")
                if (currentActivityOne.MainActors.Count >= index)
                    currentActivityOne.MainActors[index-1] = character;
                else
                    currentActivityOne.MainActors.Add(character);
        }
        public void SaveMovieGenre(string genre) {
            currentActivityOne.Genre = genre;
        }
        public void SaveMovieYear(int year) {
            currentActivityOne.Year = year;
        }
        public void SaveMovieSoundBand(string soundBand) {
            currentActivityOne.SoundBand = soundBand;
        }
        public void SaveMoviePosterBackground(int index) {
            currentActivityOne.PosterBackground = index;
        }
        public void SaveMovieAward(int index) {
            currentActivityOne.Award = index;
        }
        public void SaveMovieReflex(string reflex) {
            currentActivityOne.Reflex = reflex;
        }
        public ActivityOne getcurrentActivity() {
            return currentActivityOne;
        }
        public void SaveActivity() {
            userData.activityOneList.Add(currentActivityOne);
        }
        #endregion
    }
}