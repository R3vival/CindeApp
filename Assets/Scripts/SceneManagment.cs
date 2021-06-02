using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagment : MonoBehaviour
{
    public void EditCharacter()
    {
        ///Never Use int value to load Scenes
        SceneManager.LoadScene(Scenes.CreateAvatar);
    }
    public void LoadActivityOne() {
        SceneManager.LoadScene(Scenes.ActivityOne);
    }
    public void LoadActivityTwo() {
        SceneManager.LoadScene(Scenes.ActivityTwo);
    }
    public void LoadActivityThree() {
        SceneManager.LoadScene(Scenes.ActivityThree);
    }
    public void LoadActivityFour() {
        SceneManager.LoadScene(Scenes.ActivityFour);
    }

}
public class Scenes {
    public static string MainScene = "MenuPrincipal";
    public static string CreateAvatar = "CreateCharacter";
    public static string ActivityOne = "ActivityOne";
    public static string ActivityTwo = "ActivityTwo";
    public static string ActivityThree = "ActivityThree";
    public static string ActivityFour = "ActivityFour";
}