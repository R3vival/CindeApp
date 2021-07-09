///By R3-Santiago
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Cinde {
    [Serializable]
    public class User {
        [SerializeField]private string userName;
        [SerializeField]private Avatar avatar;

        [SerializeField] public string UserName { get => userName; set => userName = value; }
        [SerializeField] public Avatar Avatar { get => avatar; set => avatar = value; }

        ///Activitys
    }
    [Serializable]
    public class Avatar {
        public int BodyShapeID = 0;
        public int BodyShapeColorID = 0;
        public int HairCutID = 0;
        public int HairCutColorID = 0;
        public int BackHairCutID = 0;
        public int FaceID = 0;
        public int DressID = 0;
        public int MoodID = 0;

        [HideInInspector] public bool FirstSetup = false;
    }
    [Serializable]
    public class HeadShapes {
        public Sprite[] BodyShapesList;
        public Color [] BodyShapeColorList;
        public Sprite[] HairCutList;
        public Sprite[] BackHairCutList;
        public Color[] HairColorList;
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
        public List<int> Awards;


        public string QuestionOne;
        public string QuestionTwo;
        public string QuestionThree;
        public string QuestionFour;
        public string QuestionFive;
        public string Reflex;

        public ActivityOne() {
            MainActors = new List<string>();
            Awards = new List<int>();
        }
    }
    [Serializable]
    public class ActivityEight {
        public int MemeBackground;
        public string TextOne;
        public string TextTwo;

        public ActivityEight(){            
            }
    }
}