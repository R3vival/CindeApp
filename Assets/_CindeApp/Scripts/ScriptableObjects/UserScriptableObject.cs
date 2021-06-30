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
        public Moods moodsList;
        [Header("Activity One DB")]
        public ActivityOne activityOne;
        //public ActivityThree activityThree;
        //public ActivityFour activityFour;
        //public ActivityFive activityFive;
        //public ActivitySix activitySix;
        public ActivityEight activityEight;
        //public ActivityNine activityNine;
        //public ActivityTen activityTen;
        //public ActivityEleven activityEleven;
        //public ActivityTwelve activityTwelve;

    }
}