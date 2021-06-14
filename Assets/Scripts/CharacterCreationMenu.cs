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
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Submit()
    {
        PrefabUtility.SaveAsPrefabAsset(character, "Assets/Character.prefab");
        SceneManager.LoadScene(1);
    }
}
