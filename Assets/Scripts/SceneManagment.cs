///By R3-Santiago
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagment : MonoBehaviour {
    public void LoadMainMenu() {
        SceneManager.LoadScene(Scenes.MainScene);
    }
    public void LoadEditCharacterFromLogos() {
        if (!PlayerPrefs.HasKey("FirstTime")) {            
            SceneManager.LoadScene(Scenes.CreateAvatar);
        } else
            SceneManager.LoadScene(Scenes.MainScene);
    }
    public void LoadEditCharacer() {
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
    public void LoadActivityFive() {
        SceneManager.LoadScene(Scenes.ActivityFive);
    }
    public void LoadActivitySix() {
        SceneManager.LoadScene(Scenes.ActivitySix);
    }
    public void LoadActivityEight() {
        SceneManager.LoadScene(Scenes.ActivityEight);
    }
    public void LoadActivityNine() {
        SceneManager.LoadScene(Scenes.ActivityNine);
    }
    public void LoadActivityTen() {
        SceneManager.LoadScene(Scenes.ActivityTen);
    }
    public void LoadActivityEleven() {
        SceneManager.LoadScene(Scenes.ActivityEleven);
    }
    public void LoadActivityTwelve() {
        SceneManager.LoadScene(Scenes.ActivityTwelve);
    }

    public void CloseApp() {
        Application.Quit();
    }

}
public class Scenes {
    public static string MainScene = "MenuPrincipal";
    public static string CreateAvatar = "CreateCharacter";
    public static string ActivityOne = "ActivityOne";
    public static string ActivityTwo = "ActivityTwo";
    public static string ActivityThree = "ActivityThree";
    public static string ActivityFour = "ActivityFour";
    public static string ActivityFive = "ActivityFive";
    public static string ActivitySix = "ActivitySix";
    public static string ActivityEight = "ActivityEight";
    public static string ActivityNine = "ActivityNine";
    public static string ActivityTen = "ActivityTen";
    public static string ActivityEleven = "ActivityEleven";
    public static string ActivityTwelve = "ActivityTwelve";
}