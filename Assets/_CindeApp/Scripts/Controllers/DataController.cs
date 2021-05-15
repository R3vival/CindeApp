using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cinde {
    public class DataController : MonoBehaviour {
        #region Declarations
        [SerializeField] private UserScriptableObject userData;
        #endregion

        /// <summary>
        /// Get the User info from scriptableObject
        /// </summary>
        /// <returns></returns>
        public User GetUser() {
            return userData.user;
        }
        public void SetUser(User user) {
            userData.user = user;
        }
        public User CreateUser(string name, Avatar avatar) {
            User newUser = new User();

            newUser.UserName = name;
            newUser.Avatar = avatar;

            return newUser;
        }
        public string GetUserName() {
            return userData.user.UserName;
        }
        public void SetUserName(string name) {
            userData.user.UserName = name;
        }
        public Avatar GetUserAvatar() {
            return userData.user.Avatar;
        }
        public AvatarComponent GetUserHeadShape() {
            return userData.user.Avatar.HeadShape;
        }
        public void SetUserHeadShape(AvatarComponent headShape) {
            userData.user.Avatar.HeadShape = headShape;
        }
        public AvatarComponent GetUserFace() {
            return userData.user.Avatar.Face;
        }


    }
}