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
        public AvatarComponent HeadShape;
        public FaceAvatarComponent Face;
        public AvatarComponent Dress;
        public Moods mood;
    }
    [Serializable]
    public class HeadShapes {
        public AvatarComponent[] HeadShapesList;
    }
    [Serializable]
    public class Faces {
        public FaceAvatarComponent[] FacesList;
    }
    [Serializable]
    public class Dresses {
        public AvatarComponent[] DressList;

    }

    [Serializable]
    public class AvatarComponent {
        public int id;
        public int setId;
        [SerializeField] private Sprite partSprite;

        public Sprite PartSprite { get => partSprite; set => partSprite = value; }
    }
    [Serializable]
    public class FaceAvatarComponent : AvatarComponent
    {
        public Moods mood;
    }
    [Serializable]
    public class ActivityOne {
        public string Director;
        public string MovieName;
        public List<string> MainActors;
        public string Genre;
        public int Year;
        public string SoundBand;
        public int PosterBackground;
        public List<int> Award;
        public string Reflex;

        public ActivityOne() {
            MainActors = new List<string>();
        }
    }
    public enum Moods {
        Happy,
        Sad,
        Angry,
        Idle
    }
}