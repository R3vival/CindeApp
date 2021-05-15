using System;
using System.Collections;
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
        public AvatarComponent Face;
        public AvatarComponent Dress;
        public Moods mood;
    }
    public class HeadShapes {
        public AvatarComponent[] HeadShapesList;
    }
    public class Faces {
        public AvatarComponent[] FacesList;
    }
    public class Dresses {
        public AvatarComponent[] DressList;

    }

    [Serializable]
    public class AvatarComponent {
        [SerializeField] private Sprite partSprite;

        public Sprite PartSprite { get => partSprite; set => partSprite = value; }
    }

    public enum Moods {
        Happy,
        Sad,
        Angry,
        Idle
    }
}