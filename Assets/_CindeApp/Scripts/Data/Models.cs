///By R3-Santiago
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Cinde {
    [Serializable]
    public class User{
        [SerializeField]private string userName;
        [SerializeField]private Avatar avatar;

        [SerializeField] public string UserName { get => userName; set => userName = value; }
        [SerializeField] public Avatar Avatar { get => avatar; set => avatar = value; }

        ///Activitys
    }
    [Serializable]
    public class Avatar {
        public int BodyShapeID;
        public int HairCutID;
        public int BackHairCutID;
        public int FaceID;
        public int DressID;
        public int MoodID;
    }
    [Serializable]
    public class HeadShapes {
        public Sprite[] HeadShapesList;
        public Sprite[] HairCut;
        public Sprite[] BackHairCut;
    }
    [Serializable]
    public class Faces {
        public Sprite[] FacesList;
    }
    [Serializable]
    public class Dresses {
        public Sprite[] DressList;
    }
    [Serializable]
    public class Moods {
        public Sprite[] MoodsList;
    }
    [Serializable]
    public class ActivityOne {
        public string Director;
        public string MovieName;
        public List<string> MainActors;
        public string Genre;
        public int Year;
        public string SoundBand;
        public int PosterBackground = 0;
        public List<int> Award;
        public string Reflex;

        public ActivityOne() {
            MainActors = new List<string>();
            Award = new List<int>();
        }
    }
}