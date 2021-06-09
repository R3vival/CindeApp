///By R3-Santiago
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagment : MonoBehaviour
{
    public void LoadMainMenu() {
        SceneManager.LoadScene(Scenes.MainScene);
    }
    public void LoadEditCharacter()
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
    }public void LoadActivityThreePartOne() {
        SceneManager.LoadScene(Scenes.ActivityThreePartOne);
    }
    public void LoadActivityThreePartTwo() {
        SceneManager.LoadScene(Scenes.ActivityThreePartTwo);
    }
    public void LoadActivityThreePartThree() {
        SceneManager.LoadScene(Scenes.ActivityThreePartThree);
    }
    public void LoadActivityThreePartFour() {
        SceneManager.LoadScene(Scenes.ActivityThreePartFour);
    }
    public void LoadActivityThreePartFive() {
        SceneManager.LoadScene(Scenes.ActivityThreePartFive);
    }

    public void LoadActivityFour() {
        SceneManager.LoadScene(Scenes.ActivityFour);
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
    public static string ActivityThreePartOne = "ActivityThree_1";
    public static string ActivityThreePartTwo = "ActivityThree_2";
    public static string ActivityThreePartThree = "ActivityThree_3";
    public static string ActivityThreePartFour = "ActivityThree_4";
    public static string ActivityThreePartFive = "ActivityThree_5";
    public static string ActivityFour = "ActivityFour";
    public static string ActivityFive = "ActivityFive";
}