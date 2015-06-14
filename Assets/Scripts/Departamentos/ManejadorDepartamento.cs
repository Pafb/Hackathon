using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ManejadorDepartamento : MonoBehaviour {

    private Text name;
    public Image background;
     


    public void start(string name, Sprite background)
    {
        this.name.text = name;
        this.background.sprite = background;

    }
}
