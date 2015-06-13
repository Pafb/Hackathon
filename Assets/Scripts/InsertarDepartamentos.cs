using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class InsertarDepartamentos : MonoBehaviour {
    public GameObject carrousel;
    public GameObject nombre;

	// Use this for initialization
	void Start () {
        this.cargarCarrousel();
	}

    void cargarCarrousel() {
        Sprite [] fondos = Resources.LoadAll<Sprite>("Textures");
        Debug.Log(fondos.Length);
        for (int i = 0; i < fondos.Length; ++i)
        {
            GameObject elementoDelCarousel = Instantiate(Resources.Load<GameObject>("Prefabs/ImagenEnBlanco"));
            Debug.Log(elementoDelCarousel.name);
            elementoDelCarousel.GetComponent<Image>().sprite = fondos[i];
            elementoDelCarousel.transform.SetParent(carrousel.transform.FindChild("Contenido"));
            elementoDelCarousel.transform.localPosition = new Vector3((elementoDelCarousel.GetComponent<RectTransform>().rect.width + 10f) * i, 0f, 0f);
        
        }
    }
	// Update is called once per frame
	void Update () {
	
	}
}
