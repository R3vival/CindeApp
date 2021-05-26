using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cinde {
    [CreateAssetMenu(fileName ="User",menuName ="Cinde/UserData")]
    public class UserScriptableObject : ScriptableObject {
        [Header("User Data")]
        public User user;
        [Header("Assets Data")]
        public HeadShapes headsList;
        public Faces facesList;
        public Dresses dressesList;
        [Header("Activity One DB")]
        public string movieName;
        public string slogan;
        public int posterBackground;
        public string[] protagonistas;
    }
}