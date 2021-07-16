//By R3-Santiago
using UnityEngine;
using UnityEngine.UI;

public class PlaceHolderController : MonoBehaviour {
    [SerializeField] private Text text;
    public void ShowHidePlaceHolder(bool activeself) {
        if (text.text == "")
            gameObject.SetActive(activeself);
        else
            return;
    }
}