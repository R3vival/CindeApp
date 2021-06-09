using System;
using System.IO;
using UnityEngine;

namespace Cinde {
    public class JsonDeserializer {        

        /// <summary>
        /// Read Json At Android path to Get User info
        /// </summary>
        public static void UserFromJson() {
            string userString;
            string jsonPath = DataPath(DataType.User);
            CheckFileExistance(jsonPath, true);

            userString = File.ReadAllText(jsonPath);

            DataController.instance.SetUser(JsonUtility.FromJson<User>(userString));
        }
        /// <summary>
        /// Get user at DataController and Save it on a Json
        /// </summary>
        /// <param name="user"></param>
        public static void UserToJson() {
            string userString;
            string jsonPath = DataPath(DataType.User);

            CheckFileExistance(jsonPath);

            userString = JsonUtility.ToJson(DataController.instance.GetUser());
            File.WriteAllText(jsonPath, userString);
        }
        public static void ActivityOneToJson(DataType type) {
            string activityString;
            string jsonPath = DataPath(type);

            CheckFileExistance(jsonPath);

            activityString = JsonUtility.ToJson(DataController.instance.GetCurrentActivityOne());
            File.WriteAllText(jsonPath, activityString);
        }
        /// <summary>
        /// Get Path of UserData File
        /// </summary>
        /// <returns></returns>
        private static string DataPath(DataType type) {
            if (Directory.Exists(Application.persistentDataPath))
                return Path.Combine(Application.persistentDataPath, type+"Data.json");
            return Path.Combine(Application.streamingAssetsPath, type+"UserData.json");
        }
        /// <summary>
        /// Check File Existance
        /// </summary>
        /// <param name="filePath">Path of tile to check</param>
        /// <param name="isReading"></param>
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
    public enum DataType {
        User,
        ActivityOne,
        ActivityTwo,
        ActivityThree,
        ActivityFour,
        ActivityFive,        
    }
}