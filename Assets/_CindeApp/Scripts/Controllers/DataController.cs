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
        public int GetUserHeadShape() {
            return userData.user.Avatar.HeadShapeID;
        }
        /// <summary>
        /// Set headShape in current User
        /// </summary>
        /// <param name="headShape"></param>
        public void SetUserBody(int headShape) {
            userData.user.Avatar.HeadShapeID = headShape;
        }
        /// <summary>
        /// Get face from Current User
        /// </summary>
        /// <returns></returns>
        public int GetUserFace() {
            return userData.user.Avatar.FaceID;
        }
        /// <summary>
        /// Set face in current User
        /// </summary>
        /// <param name="face"></param>
        public void SetUserFace(int face) {
            userData.user.Avatar.FaceID = face;
        }
        /// <summary>
        /// Set HairCut in current User
        /// </summary>
        /// <param name="face"></param>
        public void SetUserHairCut(int face) {
            userData.user.Avatar.HairCutID = face;
        }
        /// <summary>
        /// Set BackHairCut in current User
        /// </summary>
        /// <param name="face"></param>
        public void SetUserBackHairCut(int face) {
            userData.user.Avatar.BackHairCutID = face;
        }
        /// <summary>
        /// Set Dress in current User
        /// </summary>
        /// <param name="face"></param>
        public void SetUserDress(int face) {
            userData.user.Avatar.DressID = face;
        }
        /// <summary>
        /// Set Mood in current User
        /// </summary>
        /// <param name="face"></param>
        public void SetUserMood(int face) {
            userData.user.Avatar.MoodID = face;
        }

        #region Db
        /// <summary>
        /// Get a face from database By id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Sprite GetBodyByID(int id) {
            return (Sprite)userData.facesList.FacesList[id];
        }
        /// <summary>
        /// Get a face from database By id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Sprite GetDressById(int id) {
            return (Sprite)userData.dressesList.DressList[id];
        }
        /// <summary>
        /// Get a head shape from database by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Sprite GetFaceShapeById(int id) {
            return (Sprite)userData.headsList.HeadShapesList[id];
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
        public bool SaveMovieAward(int index) {
            if (currentActivityOne.Award.Contains(index))
                return false;
            else {
                currentActivityOne.Award.Add(index);
                return true;
            }
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