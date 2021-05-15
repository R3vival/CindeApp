using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cinde {
    [CreateAssetMenu(fileName ="User",menuName ="Cinde/UserData")]
    public class UserScriptableObject : ScriptableObject {
        public User user;
    }
}