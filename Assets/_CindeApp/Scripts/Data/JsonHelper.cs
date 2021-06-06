using System;
using System.IO;
using UnityEngine;

namespace Cinde {
    public class JsonDeserializer {        

        /// <summary>
        /// Read Json At Android path to Get User info
        /// </summary>
        public void UserFromJson() {
            string userString;
            string jsonPath = DataPath();
            CheckFileExistance(jsonPath, true);

            userString = File.ReadAllText(jsonPath);

            DataController.instance.SetUser(JsonUtility.FromJson<User>(userString));
        }
        /// <summary>
        /// Get user at DataController and Save it on a Json
        /// </summary>
        /// <param name="user"></param>
        public static void UserToJson(User user) {
            string userString;
            string jsonPath = DataPath();

            CheckFileExistance(jsonPath);

            userString = JsonUtility.ToJson(user);
            File.WriteAllText(jsonPath, userString);
        }
        /// <summary>
        /// Get Path of UserData File
        /// </summary>
        /// <returns></returns>
        private static string DataPath() {
            if (Directory.Exists(Application.persistentDataPath))
                return Path.Combine(Application.persistentDataPath, "UserData.json");
            return Path.Combine(Application.streamingAssetsPath, "UserData.json");
        }
        private static void CheckFileExistance(string filePath, bool isReading = false) {
            if (!File.Exists(filePath)) {
                File.Create(filePath).Close();
                if (isReading) {
                    DataController.instance.CreateUser("R3vival",new Avatar());
                    string userString = JsonUtility.ToJson(DataController.instance.GetUser());
                    File.WriteAllText(filePath, userString);
                }
            }
        }
        
        
    }
}