using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

public class CharacterCreationMenu : MonoBehaviour
{
    public GameObject character;

    public List<EditCharacter> editCharacters = new List<EditCharacter>();
    public List<cabellochange> cabellochanges = new List<cabellochange>();
    public List<Coor> coors = new List<Coor>();

    public void Submit()
    {
        //Cinde.DataController.instance.SetUserAvatar(userAvatar);
        SceneManager.LoadScene(Scenes.MainScene);
    }
}
