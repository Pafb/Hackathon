using UnityEngine;
using System.Collections;

public class IngresarProductos : MonoBehaviour {

    public GameObject carrouselReal;
    public GameObject carrouselIconos;
    public GameObject nombre;
    public GameObject exito;

    // Use this for initialization
    void Start()
    {
        carrouselReal.GetComponent<Carrousel>().cargarCarrousel("Textures/Remos/Reales");
        carrouselIconos.GetComponent<Carrousel>().cargarCarrousel("Textures/Remos/");
    }


    public void onClickListo()
    {
        StartCoroutine(mostarMensaje());
        //gameObject.SetActive(false);
    }

    IEnumerator mostarMensaje()
    {
        exito.gameObject.SetActive(true);
        yield return new WaitForSeconds(1f);
        exito.gameObject.SetActive(false);
        gameObject.SetActive(false);
    }
}
