using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReflexController : MonoBehaviour
{   
    [SerializeField] private GameObject otherStepGameObject;
    
    [Header("Poster Asset")][SerializeField] private GameObject PanelPoster;

    public void ChangeStep() {
        otherStepGameObject.SetActive(true);
        this.gameObject.SetActive(false);
    }

    public void BackToPoster() {
        PanelPoster.SetActive(true);
        this.gameObject.SetActive(false);
    }

}
