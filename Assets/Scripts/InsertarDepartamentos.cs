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
        gameObject.SetActive(false);
    }

    IEnumerator mostarMensaje() {
        exito.gameObject.SetActive(true);
        yield return new WaitForSeconds(1f);
        gameObject.transform.FindChild("Exito").gameObject.SetActive(false);
    }
}
