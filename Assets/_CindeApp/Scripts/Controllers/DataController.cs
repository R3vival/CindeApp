///By R3-Santiago
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

namespace Cinde {
    public class DataController : MonoBehaviour {
        #region Declarations
        public static DataController instance;
        [SerializeField] private UserScriptableObject userData;
        [SerializeField] private ActivityOne currentActivityOne;
        //[SerializeField] private ActivityTwo currentActivityTwo;
        //[SerializeField] private ActivityThree currentActivityThree;
        //[SerializeField] private ActivityFour currentActivityFour;
        //[SerializeField] private ActivityFive currentActivityFive;
        //[SerializeField] private ActivitySix currentActivitySix;
        [SerializeField] private ActivityEight currentActivityEight;
        //[SerializeField] private ActivityNine currentActivityNine;
        //[SerializeField] private ActivityTen currentActivityTen;
        //[SerializeField] private ActivityEleven currentActivityEleven;
        //[SerializeField] private ActivityTwelve currentActivityTwelve;
        #endregion

        #region Unity Functions
        private void Awake() {

#if UNITY_EDITOR
            PlayerPrefs.DeleteAll();
#endif

            if (instance == null) {
                DontDestroyOnLoad(gameObject);
                instance = this;
                LoadUserInfo();
            } else if (instance != this)
                Destroy(gameObject);


        }
        private void OnApplicationQuit() {
            SaveUserInfo();
        }
        #endregion

        #region DataController Functions
        /// <summary>
        /// User Constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="avatar"></param>
        /// <returns></returns>
        public User CreateUser(string name, Avatar avatar) {
            User newUser = new User();

            newUser.UserName = name;
            newUser.Avatar = avatar;

            return newUser;
        }
        /// <summary>
        /// Save user info as Json
        /// </summary>
        public void SaveUserInfo() {
            JsonDeserializer.UserToJson();
        }
        /// <summary>
        /// load user info as Json
        /// </summary>
        public void LoadUserInfo() {
            JsonDeserializer.UserFromJson();
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
        /// Set Avatar to Current User
        /// </summary>
        /// <param name="avatar"></param>
        public bool UserHasAvatar() {
            if (userData.user.Avatar != null)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Get head shape from current User
        /// </summary>
        /// <returns></returns>
        public int GetUserHeadShape() {
            return userData.user.Avatar.BodyShapeID;
        }
        /// <summary>
        /// Set headShape in current User
        /// </summary>
        /// <param name="headShape"></param>
        public void SetUserBody(int headShape) {
            userData.user.Avatar.BodyShapeID = headShape;
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
        /// <param name="hairCut"></param>
        public void SetUserHairCut(int hairCut) {
            userData.user.Avatar.HairCutID = hairCut;
        }
        /// <summary>
        /// Set BackHairCut in current User
        /// </summary>
        /// <param name="BackHairCut"></param>
        public void SetUserBackHairCut(int BackHairCut) {
            userData.user.Avatar.BackHairCutID = BackHairCut;
        }
        public void SetUserHairColor(int color) {
            userData.user.Avatar.HairCutColorID = color;
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
            return (Sprite)userData.headsList.BodyShapesList[id];
        }
        /// <summary>
        /// Get a face from database By id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Sprite GetHairCutByID(int id) {
            return (Sprite)userData.headsList.HairCutList[id];
        }
        /// <summary>
        /// Get a face from database By id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Sprite GetBackHairCutByID(int id) {
            if (id > userData.headsList.BackHairCutList.Count())
                return null;
            else
                return (Sprite)userData.headsList.BackHairCutList[id];
        }
        public int GetBackHairCutCount() {
            return userData.headsList.BackHairCutList.Length;
        }
        public Color GetHairColor() {
            return userData.headsList.HairColorList[userData.user.Avatar.HairCutColorID];
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
            return (Sprite)userData.headsList.BodyShapesList[id];
        }
        /// <summary>
        /// Get a head shape from database by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Sprite GetFaceById(int id) {
            return (Sprite)userData.facesList.FacesList[id];
        }
        public Color GetFaceColor() {
            return userData.headsList.BodyShapeColorList[userData.user.Avatar.BodyShapeColorID];
        }
        /// <summary>
        /// Get a head shape from database by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Sprite GetMoodById(int id) {
            return (Sprite)userData.moodsList.MoodsList[id];
        }

        #endregion
        #region Activity
        /// <summary>
        /// 
        /// </summary>
        public void NewActivity(DataType type) {
            switch (type) {
                case DataType.ActivityOne:
                    currentActivityOne = new ActivityOne();
                    break;
                case DataType.ActivityThree:
                    break;
                case DataType.ActivityFour:
                    break;
                case DataType.ActivityFive:
                    break;
                case DataType.ActivitySix:
                    break;
                case DataType.ActivityEight:
                    currentActivityEight = new ActivityEight();
                    break;
                case DataType.ActivityNine:
                    break;
                case DataType.ActivityTen:
                    break;
                case DataType.ActivityEleven:
                    break;
                case DataType.ActivityTwelve:
                    break;
            }

        }
        public void SaveActivity(DataType type) {
            switch (type) {
                case DataType.ActivityOne:
                    userData.activityOne = currentActivityOne;
                    break;
            }
        }
        #endregion
        #region Activity One
        public void ActOneSaveDirector(string director) {
            currentActivityOne.Director = director;
        }
        public void ActOneSaveMovieName(string name) {
            currentActivityOne.MovieName = name;
        }
        public void ActOneSaveMainActor(string character, int index) {
            if (character != "")
                if (currentActivityOne.MainActors.Count >= index)
                    currentActivityOne.MainActors[index - 1] = character;
                else
                    currentActivityOne.MainActors.Add(character);
        }
        public void ActOneSaveMovieGenre(string genre) {
            currentActivityOne.Genre = genre;
        }
        public void ActOneSaveMovieYear(int year) {
            currentActivityOne.Year = year;
        }
        public void ActOneSaveMovieSoundBand(string soundBand) {
            currentActivityOne.SoundBand = soundBand;
        }
        public void ActOneSaveMoviePosterBackground(int index) {
            currentActivityOne.PosterBackground = index;
        }
        public bool ActOneSaveMovieAward(int index) {
            if (currentActivityOne.Awards.Contains(index))
                return false;
            else {
                currentActivityOne.Awards.Add(index);
                return true;
            }
        }
        public void ActOneSaveQuestion(string question, int index = 1) {
            switch (index) {
                case 1:
                    currentActivityOne.QuestionOne = question;
                    break;
                case 2:
                    currentActivityOne.QuestionTwo = question;
                    break;
                case 3:
                    currentActivityOne.QuestionThree = question;
                    break;
                case 4:
                    currentActivityOne.QuestionFour = question;
                    break;
                case 5:
                    currentActivityOne.QuestionFive = question;
                    break;
            }
        }
        public void ActOneSaveMovieReflex(string reflex) {
            currentActivityOne.Reflex = reflex;
        }
        public ActivityOne ActOneGetCurrentActivity() {
            return currentActivityOne;
        }

        #endregion

        #region Activity Eight
        public ActivityEight ActEightGetCurrentActivity() {
            return currentActivityEight;
        }
        public void ActEightSetMemeBackground(int index) {
            currentActivityEight.MemeBackground = index;
        }
        public int ActEightGetMemeBackground() {
            return currentActivityEight.MemeBackground;
        }
        public void ActEightSetTextOne(string text) {
            currentActivityEight.TextOne = text;
        }
        public string ActEightGetTextOne() {
            return currentActivityEight.TextOne;
        }
        public void ActEightSetTextTwo(string text) {
            currentActivityEight.TextTwo = text;
        }
        public string ActEightGetTextTwo() {
            return currentActivityEight.TextTwo;
        }
        #endregion
        #endregion

        #region App Functions

        #endregion
    }
}