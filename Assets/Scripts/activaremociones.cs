using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class activaremociones : MonoBehaviour
{
    public GameObject emocionInfo;
    public GameObject oscurecer;
    [SerializeField] Button infoBtn = null;
    private void Start()
    {

        infoBtn.onClick.AddListener(MostrarInfo);
    }

    void MostrarInfo()
    {
        emocionInfo.SetActive(true);
        oscurecer.SetActive(true);
    }

}
