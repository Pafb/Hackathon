using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class InsertarDepartamentos : MonoBehaviour {
    public GameObject carrousel;
    public GameObject nombre;
    public GameObject exito; 

	// Use this for initialization
	void Start () {
        carrousel.GetComponent<Carrousel>().cargarCarrousel("Textures");
	}


    public void onClickListo() {
        StartCoroutine(mostarMensaje());
        
    }

    IEnumerator mostarMensaje() {
        exito.gameObject.SetActive(true);
        yield return new WaitForSeconds(1f);
        exito.gameObject.SetActive(false);
        gameObject.SetActive(false);
    }
}
