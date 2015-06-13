using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class InsertarDepartamentos : MonoBehaviour {
    public GameObject carrousel;
    public GameObject nombre;

	// Use this for initialization
	void Start () {
        carrousel.GetComponent<Carrousel>().cargarCarrousel("Textures");
	}

    
	// Update is called once per frame
	void Update () {
	
	}
}
