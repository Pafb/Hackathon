using UnityEngine;
using System.Collections;

public class Imagen : MonoBehaviour {

    public string path = "";
    public GameObject carrousel; 

    public void onClickImage() {
        Debug.Log(path);
        carrousel.GetComponent<Carrousel>().selected = path;
    }
}
