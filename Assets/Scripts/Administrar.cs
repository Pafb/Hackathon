using UnityEngine;
using System.Collections;

public class Administrar : MonoBehaviour {
    string departamento;
    string categoria;
    string producto;

    public GameObject modelAgregarDepartamento;
    public GameObject a;
    public GameObject b;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void agregarDepartamento() {
        modelAgregarDepartamento.SetActive(true);
        //tiene que llamar la cosa de JSON de Andree.
    }

    public void agregarCategoria()
    {
        a.SetActive(true);
        //tiene que llamar la cosa de JSON de Andree.
    }

    public void agregarProducto()
    {
        b.SetActive(true);
        //tiene que llamar la cosa de JSON de Andree.
    }



}
