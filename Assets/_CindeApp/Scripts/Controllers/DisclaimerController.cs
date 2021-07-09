using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisclaimerController : MonoBehaviour
{
    SceneManagment sceneManager;

    private void Awake() {

#if UNITY_EDITOR
        PlayerPrefs.DeleteAll();
#endif

        sceneManager = this.GetComponent<SceneManagment>();

        sceneManager.LoadLogos();
    }
}
