using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GuardarTexto : MonoBehaviour
{
    public GameObject[] slotsIniciales;
    public GameObject[] slotsFinales;
    [SerializeField] Button continuarBtn = null;
    [SerializeField] Button backBtn;

    private void Start()
    {
        continuarBtn.onClick.AddListener(TextosElegidos);
        backBtn.onClick.AddListener(TextosRollBack);
    }

    private void TextosElegidos()
    {
        for (int i = 0; i < slotsIniciales.Length; i++)
        {
            RectTransform child = slotsIniciales[i].transform.GetChild(0).GetComponent<RectTransform>();
            child.transform.SetParent(slotsFinales[i].transform);
            child.transform.position = slotsFinales[i].transform.position;
        }
    }
    private void TextosRollBack() {
        for (int i = 0; i < slotsFinales.Length; i++) {
            RectTransform child = slotsFinales[i].transform.GetChild(0).GetComponent<RectTransform>();
            child.transform.SetParent(slotsIniciales[i].transform);
            child.transform.position = slotsIniciales[i].transform.position;
        }
    }
}
